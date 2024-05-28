using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

public class RsaEncryption
{
    private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
    private RSAParameters _privateKey;
    private RSAParameters _publicKey;

    public RsaEncryption()
    {
        _privateKey = csp.ExportParameters(true);
        _publicKey = csp.ExportParameters(false);
    }

    public string GetPublicKey()
    {
        var sw = new StringWriter();
        var xs = new XmlSerializer(typeof(RSAParameters));
        xs.Serialize(sw, _publicKey);
        return sw.ToString();
    }

    public string Encrypt(string plainText)
    {
        csp = new RSACryptoServiceProvider(2048);
        csp.ImportParameters(_publicKey);
        var data = Encoding.Unicode.GetBytes(plainText);
        var cypher = csp.Encrypt(data, false);
        return Convert.ToBase64String(cypher);

    }

    public string Decrypt(string cypherText)
    {
        var dataByte = Convert.FromBase64String(cypherText);
        csp.ImportParameters(_privateKey);
        var plainText = csp.Decrypt(dataByte, false);
        return Encoding.Unicode.GetString(plainText);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        RsaEncryption rsa = new RsaEncryption();
        string cypher = string.Empty;
        string plainText = string.Empty;
        Console.WriteLine($"PUblic Key: {rsa.GetPublicKey()} \n");
        Console.WriteLine("enter your text to encrypt");
        var text = Console.ReadLine();
        if (!string.IsNullOrEmpty(text))
        {
            cypher = rsa.Encrypt(text);
            Console.WriteLine($"Encrypted Text: {cypher}");
        }

        Console.WriteLine("press any key to decrypt text");
        Console.ReadLine();
        plainText = rsa.Decrypt(cypher);

        Console.WriteLine($"Decrypted Message: {plainText}");
        Console.ReadLine();
    }
}
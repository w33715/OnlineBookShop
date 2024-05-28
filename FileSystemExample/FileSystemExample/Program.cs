



internal class Program
{
    public static void Main()
    {
        try
        {
            string FileName = @"C:\Users\igord\source\repos\JSONNetBeispiel_Console\JSONNetBeispiel_Console\bin\Debug\sabrina.json";

            Console.WriteLine("Encrypt " + FileName);

            // Encrypt the file.
            AddEncryption(FileName);

            Console.WriteLine("Decrypt " + FileName);

            // Decrypt the file.
            // RemoveEncryption(FileName);

            Console.WriteLine("Done");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        Console.ReadLine();
    }

    // Encrypt a file.
    public static void AddEncryption(string FileName)
    {

        File.Encrypt(FileName);
    }

    // Decrypt a file.
    public static void RemoveEncryption(string FileName)
    {
        File.Decrypt(FileName);
    }
}

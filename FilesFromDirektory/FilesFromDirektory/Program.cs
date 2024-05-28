using System;
using System.IO;

namespace FilesFromDirektory
{
    public class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo di = new DirectoryInfo(@"D:\Eltern");
            Console.WriteLine("No search pattern returns:");
            foreach (var fi in di.GetFiles())
            {
                Console.WriteLine(fi.Name);
            }

            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Search pattern *2* returns:");
            foreach (var fi in di.GetFiles("*2*"))
            {
                Console.WriteLine("{0}\t, Datum: {1}", fi.Name, fi.LastAccessTime.ToString());
            }

            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Search pattern *.pdf returns:");
            foreach (var fi in di.GetFiles("*.pdf"))
            {
                Console.WriteLine(fi.Name.Remove(fi.Name.Length - 4));

            }

            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Search pattern AllDirectories returns:");
            foreach (var fi in di.GetFiles("*", SearchOption.AllDirectories))
            {
                Console.WriteLine(fi.Name);

            }
            Console.ReadKey();
        }
    }
}

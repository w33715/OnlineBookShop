using System;
using System.Threading;

namespace AsyncBeispiel
{
    internal class Program
    {
        private static void Main()
        {
            //Konstruktor mit Methodaufruf
            Thread thread = new Thread(new ParameterizedThreadStart(WriteChar));

            Console.WriteLine("Zum starten - beliebige Taste drücken");
            Console.ReadKey();
            thread.Start('*');
            for (int i = 0; i < 80; i++)
            {
                Console.Write('-');
                Thread.Sleep(70);
            }

        }
        private static void WriteChar(object arg)
        {
            char item = (char)arg;
            for (int i = 0; i < 80; i++)
            {
                Console.Write(item);
                Thread.Sleep(70);
            }
        }
    }
}

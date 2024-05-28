using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Alina",
                "Anna",
                "Anton",
                "Peter",
                "Roland",
                "Markus",
                "Agnes",
                "Christian"

            };
            var query = from name in names
                        where name.StartsWith("a", System.StringComparison.InvariantCultureIgnoreCase)
                        select name;
            Console.WriteLine("Alle Namen die mit A anfangen");
            foreach (var name in query)
            {
                Console.WriteLine(name);

            }

            Console.ReadKey();

        }
    }

}

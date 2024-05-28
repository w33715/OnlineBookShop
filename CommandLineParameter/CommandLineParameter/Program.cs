using System;
using System.ComponentModel.DataAnnotations;

using McMaster.Extensions.CommandLineUtils;

namespace CommandLineParameter
{
    [Command(Description = "Programm description", Name = "Test App")]
    [HelpOption("-?|--help")]
    internal class Program
    {
        [Required]
        [Option("-n|--name", CommandOptionType.SingleValue, Description = "Name")]
        public string Name { get; set; }

        [Option("-d|--debug", CommandOptionType.SingleOrNoValue, Description = "Debug")]
        public bool Debug { get; set; }

        [Option("-p|--phone", CommandOptionType.MultipleValue, Description = "Phones")]
        public string[] Phones { get; set; }
        public static void Main(string[] args)
             => CommandLineApplication.Execute<Program>(args);
        public void OnExecute()
        {
            Console.WriteLine("Hello, World");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Debug: " + Debug);
            if (Phones != null)
            {
                Console.WriteLine("Phones: " + string.Join(" ", Phones));
            }

            else
            {
                Console.WriteLine("Phones empty");
            }
            Console.ReadKey();
        }
    }
}

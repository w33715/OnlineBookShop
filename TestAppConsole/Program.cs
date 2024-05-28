using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using XmlLibrary;

namespace TestAppConsole
{

    internal class Program
    {
        [SoapInclude(typeof(ObjectSpeisung))]
        static void Main(string[] args)
        {

            var memberList = new List<ObjectSpeisung>
            {
                new ObjectSpeisung
                {
                Name1 = "Igor",
                Email1 = "igor@web.de",
                Age1 = 30,
                Birthdate1 = DateTime.Now,
                IsPlatinumMember1 = false

                }

            };

            //   Xml_Library xmlLibrary = new Xml_Library();
            Xml_Library.ObjectToXmlFile(memberList, @"Test4.xml");
            Console.WriteLine("Datei sind gespeichert...\n Press any key");
            Xml_Library.XmlFileToObject(@"Test4.xml");
            List<ObjectSpeisung> objectSpeisungs = new List<ObjectSpeisung>();
            foreach (var item in objectSpeisungs)
            {
                Console.WriteLine(item.Name1);
                Console.WriteLine(item.Email1);
                Console.WriteLine(item.Age1);
                Console.WriteLine(item.Birthdate1);
                Console.WriteLine(item.IsPlatinumMember1);
            }
            Console.WriteLine("Process is completed...\n Press any key...");

            Console.ReadKey();

        }
    }
}

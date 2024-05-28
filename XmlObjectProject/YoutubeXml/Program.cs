using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace YoutubeXml
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SerializeObjectToXmlFile();
             DeserializeFileToList();
           // SerializeObjectToXmlFile();
            // DeserializeXmlFileToObject();
            // SerializeObjectToXmlString();
            Console.WriteLine("Process completed....");
            Console.ReadKey();
        }
        private static void SerializeObjectToXmlString()
        {
            var member = new Member
            {
                Name = "John",
                Email = "john@gmail.com",
                Age = 30,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
            };
            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, member);
                var xmlContent = writer.ToString();
                Console.WriteLine(xmlContent);
                DeserialiseXmlStringToObject(xmlContent);
            }
        }
        private static void DeserialiseXmlStringToObject(string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var reader = new StringReader(xmlString))
            {
                var member = (Member)xmlSerializer.Deserialize(reader);
            }
        }
        private static void SerializeObjectToXmlFile()
        {
            var member = new Member
            {
                Name = "John",
                Email = "john@gmail.com",
                Age = 30,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
            };
            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var writer = new StreamWriter(@"Test2.xml"))
            {
                xmlSerializer.Serialize(writer, member);
            }
        }
        private static void SerializeListToXmlFile()
        {
            var memberList = new List<Member>
            {
                new Member
    {
        Name = "John",
                Email = "john@gmail.com",
                Age = 30,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
    },
    new Member
    {
        Name = "Peter",
                Email = "peter@gmail.com",
                Age = 35,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = true
    },
        new Member
        {
         Name = "David",
                Email = "David@gmail.com",
                Age = 25,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = true
            },
        new Member
    {
        Name = "George",
                Email = "george@gmail.com",
                Age = 29,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
    }
        };
            var xmlSerializer = new XmlSerializer(typeof(List<Member>));
            using (var writer = new StreamWriter(@"Test3.xml"))
            {
                xmlSerializer.Serialize(writer, memberList);
            }

        }
        public static void DeserializeFileToList()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Member>));
            using (var reader = new StreamReader(@"test3.xml"))
            {
                var members = (List<Member>)xmlSerializer.Deserialize(reader);
                foreach (var item in members)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Email);
                    Console.WriteLine(item.Age);
                    Console.WriteLine(item.JoiningDate);
                    Console.WriteLine(item.IsPlatinumMember);
                    Console.WriteLine();
                }
            }
        }
        public static void DeserializeXmlFileToObject()
        {
            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var reader = new StreamReader(@"test2.xml"))
            {
                var member = (Member)xmlSerializer.Deserialize(reader);

           
            }

            
        }
    }
}

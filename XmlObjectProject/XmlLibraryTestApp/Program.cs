using System;

using XmlObjectLibrary;

namespace XmlLibraryTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\Programmierung\Projekte_C#\XmlObjectProject\test.xml";
            UserItems Items = UserItems.Open();
            foreach (var item in Items)
            {
                Console.WriteLine(item.System);
                Console.WriteLine(item.User);
                Console.WriteLine(item.Password);
            }
            UserItems models = new UserItems();
            //models.Remove(new ItemModel { System = "100", User = "You", Password = "505" });
            // models.Add(new UserItems { System = "350", User = "You", Password = "500" });

            // models.RemoveAt(0);
            //  PassStoreLib.ObjectToXml(filepath, models);
            PassStoreLib.DeserializeFileToList(filepath);
            Console.ReadKey();


        }
    }
}

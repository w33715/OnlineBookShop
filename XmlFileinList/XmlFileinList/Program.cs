using System;

using XmlFileToListLibrary;

namespace XmlFileinList
{
    class Program
    {

        static void Main(string[] args)
        {
            string fileFullPath = @"D:\Programmierung\Projekte_C#\XamlDatenRead\XamlDatenRead\bin\Debug\userdata.xml";
            XmlReadToList.ReadDataFromXml(fileFullPath, "IDmitrienko");
            Console.ReadKey();
        }
    }
}

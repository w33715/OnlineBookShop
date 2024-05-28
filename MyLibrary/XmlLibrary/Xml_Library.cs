using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


namespace XmlLibrary
{
    public class Xml_Library
    {

        //public static bool SerialiseListToXmlFile(Object obj, string filepath)
        //{
        //    var objectList = new List<Object>
        //    {
        //        obj
        //    };
        //    var xmlSerializer = new XmlSerializer(typeof(List<Object>));
        //    using (var writer = new StreamWriter(filepath))
        //    {
        //        xmlSerializer.Serialize(writer, objectList);
        //    }
        //    return true;
        //}


        //Serilization
        public static bool ObjectToXmlFile(object obj, string filePath)
        {
            XmlTextWriter writer = new XmlTextWriter(filePath, new UTF8Encoding());
            XmlSerializer xse = new XmlSerializer(obj.GetType());
            xse.Serialize(writer, obj);
            writer.Close();
            return true;
        }

        //Deserilization

        public static List<object> XmlFileToObject(string filePath)
        {
            if (File.Exists(filePath))
            {
                //List<object> list = new List<object>();
                //FileStream fstream = new FileStream(filePath, FileMode.OpenOrCreate);
                //XmlReader reader = new XmlTextReader(fstream);
                //XmlSerializer xser = new XmlSerializer(typeof(List<object>));
                //Object obj = xser.Deserialize(reader);
                //list.Add(obj);
                //reader.Close();
                //return list;

                var xmlSerializer = new XmlSerializer(typeof(List<object>));
                using (var reader = new FileStream(@"test4.xml", FileMode.Open))
                {
                    var members = (List<object>)xmlSerializer.Deserialize(reader);
                    foreach (var item in members)
                    {
                        //Console.WriteLine(item.Name1);
                        //Console.WriteLine(item.Email1);
                        //Console.WriteLine(item.Age);
                        //Console.WriteLine(item.JoiningDate);
                        //Console.WriteLine(item.IsPlatinumMember);
                        //Console.WriteLine();
                    }
                }
            }
            return null;
        }


    }
}

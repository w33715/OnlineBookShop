using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XmlObjectLibrary
{
    public class PassStoreLib
    {

        //Serilization
        public static bool ObjectToXml(string filepath, object obj)
        {
            XmlTextWriter writer = new XmlTextWriter(filepath, new UTF8Encoding());
            XmlSerializer xse = new XmlSerializer(typeof(object));
            xse.Serialize(writer, obj);
            return true;
        }

        //Deserialization
        public static UserItems XmlToObject(string filepath)
        {
            if (File.Exists(filepath))
            {
                UserItems models = new UserItems();
                FileStream fstream = new FileStream(filepath, FileMode.OpenOrCreate);
                XmlReader reader = new XmlTextReader(fstream);
                XmlSerializer xser = new XmlSerializer(typeof(UserItems));
                Object obj = xser.Deserialize(reader);
              
                reader.Close();
                return models;
            }
            return null;
        }
        public static UserItems DeserializeFileToList(string filepath)
        {
            UserItems models = new UserItems();
            var xmlSerializer = new XmlSerializer(typeof(UserItems));
            using (var reader = new StreamReader(filepath))
            {
                var members = (UserItems)xmlSerializer.Deserialize(reader);
                models.Add(members);
            }

            return models;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Xml;

namespace XamlDatenRead
{
    public class UserData
    {
        public string Key { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class Program
    {
        public static void XmlRead()
        {
            string FilePath = @"D:\Programmierung\Projekte_C#\XamlDatenRead\XamlDatenRead\bin\Debug\userdata.xml";
            string _key = string.Empty;
            string _username = string.Empty;
            string _password = string.Empty;
            IList<UserData> users = new List<UserData>();
            XmlReader reader = XmlReader.Create(FilePath);
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name.ToString())
                    {
                        case "Key":
                            _key = reader.ReadString();
                            break;
                        case "UserName":
                            _username = reader.ReadString();
                            break;
                        case "Password":
                            _password = reader.ReadString();
                            break;

                    }


                }
                // users.Add(new UserData { Key = _key, UserName = _username, Password = _password });
            }

            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            XmlRead();
        }
    }
}

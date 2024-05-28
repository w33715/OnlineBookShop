using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XmlFileToListLibrary
{
    public class XmlReadToList
    {
        public static List<Users> userList;
        public static void ReadDataFromXml(string FilePath, string MaskeKey)
        {
            userList = (
        from e in XDocument.Load(FilePath)
            .Root.Elements("User")
        select new Users
        {
            Key = (string)e.Element("Key"),
            UserName = (string)e.Element("UserName"),
            Password = (string)e.Element("Password")
        }
            ).ToList();

            var result = from a in userList
                         where a.Key == MaskeKey || a.UserName == MaskeKey
                         select new { a.UserName, a.Password };

            foreach (var item in result)
            {
                Console.WriteLine("\t" + item.UserName + "\t" + item.Password);
            }

        }
    }
    public class Users
    {
        public string Key { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

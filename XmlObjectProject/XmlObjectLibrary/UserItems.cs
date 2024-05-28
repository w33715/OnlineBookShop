using System;
using System.Collections.ObjectModel;

namespace XmlObjectLibrary
{
    public class UserItems : KeyedCollection<string, ItemModel>
    {
        static string filepath = @"D:\Programmierung\Projekte_C#\XmlObjectProject\test.xml";
        public static UserItems Open()
        {
            UserItems items;
            //  items = PassStoreLib.XmlToObject(filepath);
            items = PassStoreLib.XmlToObject(filepath);
            if (items == null)
            {
                return new UserItems();
            }
            else { return items; }
        }

        protected override string GetKeyForItem(ItemModel item) => item.System + item.User;
        public bool Save()
        {
            PassStoreLib.ObjectToXml(filepath, this);
            Console.WriteLine("OK");
            return true;
        }
        public static bool NewItems()
        {
            UserItems items = new UserItems();
            //items.Add(new ItemModel());
            PassStoreLib.ObjectToXml(filepath, items);
            return true;
        }

        internal void Add(UserItems members)
        {
            throw new NotImplementedException();
        }
    }
}

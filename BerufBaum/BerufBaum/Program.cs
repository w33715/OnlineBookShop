using System;
using System.Collections.Generic;

namespace BerufBaum
{
    public class AllBerufs
    {
        public string AllBeruf { get; set; }
        public bool IsChecked { get; set; }
        public List<BerufCategory> categoryList { get; set; }
    }
    public class BerufCategory
    {
        public string CategoryName { get; set; }
        public bool IsChecked { get; set; }
        public List<Beruf> berufList { get; set; }
    }
    public class Beruf
    {
        public string BerufName { get; set; }
        public bool IsChecked { get; set; }

    }
    internal class Program
    {
        private static AllBerufs allBerufs;

        static void Main(string[] args)
        {
            List<BerufCategory> categoryList = new List<BerufCategory>();
            List<Beruf> berufList = new List<Beruf>();

            allBerufs = new AllBerufs
            {
                AllBeruf = "Alle Berufe",
                IsChecked = false,
                categoryList = new List<BerufCategory>
                {
                    new BerufCategory
                    {
                      CategoryName = "IT-Berufe",
                      IsChecked = false,
                      berufList=new List<Beruf>
                      {
                        new Beruf{BerufName="Programmierer", IsChecked=false},
                        new Beruf{BerufName="Softwareentwikler", IsChecked=false}

                      }
                    },
                    new BerufCategory
                    {
                        CategoryName="Elektroberufe",
                        IsChecked=false,
                        berufList=new List<Beruf>
                        {
                            new Beruf { BerufName="Elektriker", IsChecked=false }
                        }
                    }
                }
            };

            Console.WriteLine(allBerufs.ToString());
            Console.ReadKey();

        }
    }




}



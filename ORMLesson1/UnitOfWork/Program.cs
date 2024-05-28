using System;
using System.Configuration;

using Company = Logic.Domain.Company;
using U = DAL;

namespace UnitOfWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            var connection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            Console.WriteLine(connection);

            //var company = new Company("Igorinko", new DateTime(2022, 12, 31));
            var context = new U.UnitOfWork(connection);
            var companies = context.CompanyRepository.GetAll();
            foreach (var item in companies)
            {
                Console.WriteLine(item.CompanyName);
            }
            while (true)
            {
                Console.WriteLine("Menu: \n 1. Company create");
                int selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    Console.WriteLine("Enter company name");
                    string name = Console.ReadLine();
                    var company1 = new Company(name, DateTime.Now);
                    context.CompanyRepository.Save(company1);
                    context.Commit();
                    var companies1 = context.CompanyRepository.GetAll();
                    foreach (var item in companies1)
                    {
                        Console.WriteLine(item.CompanyName);
                    }
                }
                Console.ReadKey();
            }
            //    context.CompanyRepository.Save(company);




        }

        public static void ListOfCompanies()
        {

        }


    }
}

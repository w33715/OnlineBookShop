using System;
using System.Collections.Generic;

namespace Logic.Domain
{
    public class Company : Identity
    {
        public Company()
        {
            Employees = new List<Employee>();
            IsActual = true;

        }
        public Company(string name, DateTime date) : this()
        {
            CompanyName = name;
            OpeningDate = date;
            IsActual = true;
        }
        public string CompanyName { get; set; }
        public DateTime OpeningDate { get; set; }
        public List<Employee> Employees { get; set; }
        public bool IsActual { get; set; }

    }
}

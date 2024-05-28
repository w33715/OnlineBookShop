using System;

namespace Logic.Domain
{
    public class Employee : Identity
    {
        public Employee() { }
        public Employee(string fName, string lName, Company company, string position, DateTime hireData)
        {
            FirstName = fName;
            LastName = lName;
            Company = company;
            Position = position;
            HireDate = hireData;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Company Company { get; set; }

        public string Position { get; set; }
        public DateTime HireDate { get; set; }
        public int Age { get; set; }
    }
}

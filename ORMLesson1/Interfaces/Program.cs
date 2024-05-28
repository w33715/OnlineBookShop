using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var company = new Company()
            {
                Id = 1,
                CompanyName = "name"
            };

            var user = new User()
            {
                Id = 1,
                Name = "ivan"
            };
            string item = "Etwas";

            var samsung = new Phone<User>(new FaceUnlock());
            var iphone = new Phone<Company>(new FingerPrintUnlock());
            var nokia3310 = new Phone<User>(new BaseSecurity());

            samsung.Owner = user;
            iphone.Owner = company;
            nokia3310.Owner = user;

            Console.WriteLine(samsung.Owner.Name);
            Console.WriteLine(iphone.Owner.CompanyName);
            Console.WriteLine(nokia3310.Owner.Name);
            Console.WriteLine("######################");
            Console.WriteLine();


            nokia3310.UnlockPhone();
            Console.WriteLine("######################");
            samsung.UnlockPhone();
            Console.WriteLine("######################");
            iphone.UnlockPhone();

            Console.ReadKey();
        }
    }
}

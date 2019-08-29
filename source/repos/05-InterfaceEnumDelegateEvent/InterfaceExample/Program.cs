using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        enum Weekdays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday = 20,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            ISecurityService googleSS = new GoogleSecurityService();
            ISecurityService facebookSS = new FacebookSecurityService();
            /*ISecurityService faceSS = new FakeSecurityService();

            AccountController ac = new AccountController(googleSS);
            ac.ChangeUserPassword(....);

            AccountController anotherAC = new AccountController(facebookSS);
            anotherAC.ChangeUserPassword(....);
            */

            BankAccount ba1 = new BankAccount(1000, "John");
            BankAccount ba2 = new BankAccount(2000, "Jared");
            BankAccount ba3 = new BankAccount(5000, "Don");

            var bankList = new List<BankAccount>();
            bankList.Add(ba1);
            bankList.Add(ba2);
            bankList.Add(ba3);

            bankList.Sort();
            foreach (var item in bankList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Weekdays.Friday);
            Console.WriteLine((int)Weekdays.Friday);

            Console.WriteLine(Weekdays.Monday);
            Console.WriteLine((int)Weekdays.Monday);

            Console.WriteLine(Enum.GetName(typeof(Weekdays), 4));

            foreach (var item in Enum.GetNames(typeof(Weekdays)))
            {
                Console.WriteLine(item);
            }
        }

        void MyFun(Weekdays aDay)
        {

        }
    }
}

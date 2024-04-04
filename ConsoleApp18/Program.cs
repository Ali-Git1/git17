using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sifre daxil edin : ");
            string Password = Console.ReadLine();
            User user = new User("Ali Aliyev", "Ali.dev@gmail.com", Password);

            user.PasswordChecker(user.Password);

            user.ShowInfo();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class User:IAccount
    {
        public string FullName { get; set; }
        public string Email { get; set; }
       
        public string Password { get; set; }

        public User(string fullname,string email,string password)
        {
            FullName=fullname;
            Email=email;
            Password = password;
        }

        public void PasswordChecker(string Password)
        {
            bool boyukherf = false;
            bool kicikherf = false;
            bool reqem = false;

            foreach (char c in Password)
            {
                if(char.IsUpper(c))
                {
                    boyukherf=true;
                }
                else if(char.IsLower(c))
                {
                    kicikherf=true;
                }
                else if(char.IsDigit(c))
                {
                    reqem=true;
                }
            }

            bool a = Password.Length >= 8 && boyukherf && kicikherf && reqem;

            if(a)
            {
                Console.WriteLine("Sifre dogrudur");
            }
            else
            {
                Console.WriteLine("Dogru deyil");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Ad Soyad:{FullName}");
            Console.WriteLine($"Email:{Email}");
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
namespace ChatApp.Domain.Repositories
{
    public class User
    {
        public void LogIn()
        {
            Console.WriteLine("LOG IN");
            Console.WriteLine("mail: ");
            Console.ReadLine();
            Console.WriteLine("password: ");
            Console.ReadLine();
            // check if user exists
        }
        public void SignUp()
        {
            Console.WriteLine("LOG IN");
            Console.WriteLine("mail: ");
            Console.ReadLine();
            // check if email is valid
            Console.WriteLine("password: ");
            Console.ReadLine();
            Console.WriteLine("repeat password: ");
            Console.ReadLine();
            // check if passwords are same
            // captcha
        }
    }
}

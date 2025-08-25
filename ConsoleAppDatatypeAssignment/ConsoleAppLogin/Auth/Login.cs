using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLogin.Auth
{
    internal class Login
    {
        private string correctUsername = "admin";
        private string correctPassword = "1234";

        public void StartLogin()
        {
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("Login successful!");
                    return; // Exit method
                }
                else
                {
                    attempts++;
                    Console.WriteLine($" Invalid credentials. Attempts left: {3 - attempts}");
                }
            }

            Console.WriteLine(" Too many attempts. Access denied.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattens_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Access_controled_library library = new Access_controled_library();

            User u1 = new User("Odense", "John");
            User u2 = new User("Test_log", "Test");
            Book b1 = new Book() { Name = "1984", Author = "George Orwell", ISBN = "978-1-23-456789-7" };
            Book b2 = new Book() { Name = "White Fang", Author = "Jack London", ISBN = "911-5-29-456759-3" };
            Book b3 = new Book() { Name = "American Gods", Author = "Neil Gaiman", ISBN = "978-1-10-769989-2" };

            library.AddBook(b1);
            library.AddBook(b2);
            library.AddBook(b3);
            library.AddUser(u1);
            library.AddUser(u2); 

            while (true)
            {
                Console.Write("Enter login to access: ");
                string enteredLogin = Console.ReadLine();
                User incoming = library.GetUsers().Find((x) => x.login == enteredLogin);

                if(incoming != null)
                {
                    library.Access_to_library(incoming);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ACCESS FORBIDDEN!\nYou should register at library!");
                    Console.ResetColor();
                    Console.Write("Choose login: ");
                    string registerLogin = Console.ReadLine();
                    Console.Write("Enter your name: ");
                    string registerName = Console.ReadLine();
                    User registered = new User(registerLogin, registerName);
                    library.AddUser(registered);
                }
            }

            HexadecimalCalculator calc = new RichHexadecimalCalculator();
            Console.Write("Enter first hexadecimal number (max length - 7) - ");
            string hexNumber1 = Console.ReadLine();
            Console.Write("Enter second hexadecimal number (max length - 7) - ");
            string hexNumber2 = Console.ReadLine();
            Console.Write("Sum: " + calc.Calculate(hexNumber1, hexNumber2));

            Console.ReadKey();
        }
    }
}

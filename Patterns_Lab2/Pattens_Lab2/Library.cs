using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattens_Lab2
{
    class User
    {
        public string login;
        public string name;

        public User (string login, string name)
        {
            this.login = login;
            this.name = name;
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

    abstract class Abst_Library
    {
        public abstract void Access_to_library(User u);
        public abstract void AddBook(Book book);
    }

    class Library : Abst_Library
    {
        List<Book> books = new List<Book>();

        public Library()
        {

        }

        public Library(List<Book> books)
        {
            this.books = books;
        }

        public override void AddBook(Book book)
        {
            books.Add(book);
        }

        public override void Access_to_library(User u)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------Access granted, welcome, {0}!----------", u.login);
            Console.ResetColor();
            Console.WriteLine("Here is our library:\n");
            foreach (Book b in books)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Book name: {0}", b.Name);
                Console.WriteLine("Book author: {0}", b.Author);
                Console.WriteLine("Book ISBN: {0}", b.ISBN);
            }
        }
    }

    class Access_controled_library : Abst_Library
    {
        Library lib = new Library();
        List<User> users = new List<User>();
        public Access_controled_library()
        {

        }

        public Access_controled_library(List<User> users)
        {
            this.users = users;
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }
        
        public List<User> GetUsers()
        {
            return users;
        }

        public override void AddBook(Book book)
        {
            lib.AddBook(book);
        }

        public override void Access_to_library(User u)
        {
            string login = u.login;
            foreach (User user in users)
            {
                if (user.login == login)
                {
                    lib.Access_to_library(u);
                }
            }
        }
    }
}

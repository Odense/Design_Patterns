using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator cr = new Creator();
            IDrink drink;
            Console.WriteLine("Which drink do you want (Tea/Coffee/Hot chocolate)?");
            string drink_type = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter additional options\n-------------------------------------------\nFor Tea: Shugar/Lemon/Shugar&lemon\nFor Coffee: Shugar/Milk/Shugar&milk\nFor Hot chocolate we have no additional options :-(\n-------------------------------------------\nIf you don't want additional options — just press ENTER");
            string options = Console.ReadLine();
            drink = cr.DrinkMachine(drink_type);
            Console.WriteLine("Ok'ay, here is your {0}", drink.kind(options));

            Console.ReadKey();
        }
    }
}

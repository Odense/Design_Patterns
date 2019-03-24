using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextAutomat contextAutomat = new ContextAutomat();
            Console.WriteLine("------Current automat state is idleness!-----\n");
            while (true)
            {
                Console.WriteLine("If you want to change automat state - press 'Enter' or 'Esc' to finish");
                if (Console.ReadKey().Key == ConsoleKey.Enter) contextAutomat.SetState(ContextAutomat.AutomatStateSetting.Working);
                else if (Console.ReadKey().Key == ConsoleKey.Escape) break;
                contextAutomat.Working();
                Console.WriteLine("If you want to change automat state - press 'Enter' or 'Esc' to finish");
                if (Console.ReadKey().Key == ConsoleKey.Enter) contextAutomat.SetState(ContextAutomat.AutomatStateSetting.Idleness);
                else if (Console.ReadKey().Key == ConsoleKey.Escape) break;
                contextAutomat.Working();
            }

            PurchasedItem itm = new PurchasedItem();
            Console.WriteLine("Via which shopping type do you want to buy item?\n('online' or 'real')");
            string typeInput = Console.ReadLine();
            string onlineInput;

            OnlineShopping onlineShopping = new OnlineShopping();
            RealShopping realShopping = new RealShopping();

            if (typeInput == "online")
            {
                itm.SetShoppingType(onlineShopping);
                Console.WriteLine("Via which payment method and delivery type do you want to buy item?\n('CashToCourier' or 'CardAndPickup')");
                onlineInput = Console.ReadLine();
                itm.shoppingType = onlineInput;
            }
            else itm.SetShoppingType(realShopping);

            Console.WriteLine(itm.ItemShoppingType.ToString());

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab3
{
    interface IDrink
    {
        string kind(string options);
    }

    class Tea : IDrink
    {
        public String kind(string options)
        {
            switch (options)
            {
                case "Shugar": return "Tea with shugar";
                case "Lemon": return "Tea with lemon";
                case "Shugar&lemon": return "Tea with shugar&lemon";
                default: return "Tea";
            }
        }
    }

    class Coffee : IDrink
    {
        public String kind(string options)
        {
            switch (options)
            {
                case "shugar": return "Coffee with shugar";
                case "Milk": return "Coffee with milk";
                case "Shugar&milk": return "Coffee with shugar&milk";
                default: return "Coffee";
            }
        }
    }

    //Singleton
    class HotChocolate : IDrink
    {
        static HotChocolate instance;

        public String kind(string options)
        {
            return "Hot chocolate";
        }

        protected HotChocolate() {}

        public static HotChocolate getInstance()
        {
            if (instance == null) instance = new HotChocolate();
            return instance;
        }
    }

    class DefaultDrink : IDrink
    {
        public String kind(string options)
        {
            return "No drinks available";
        }
    }

    class Creator
    {
        public IDrink DrinkMachine(string drink)
        {
            switch (drink)
            {
                case "Tea": return new Tea();
                case "Coffee": return new Coffee();
                case "Hot chocolate": return HotChocolate.getInstance();
                default: return new DefaultDrink();
            }
        }
    }
}

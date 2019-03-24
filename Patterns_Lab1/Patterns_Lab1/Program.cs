using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Task1 (Bridge)-------------");
            //Students
            AbstractStudent ab = new AbstractStudent();

            // Set implementation and call
            ab.Student = new ExcellentStudent();
            ab.PassTest();

            ab.Student = new UnsatisfactoryStudent();
            ab.PassTest();

            // Pets
            Console.WriteLine("--------------Task2 (Composite)----------");
            //street is a root
            Composite street = new Composite("Hnata Yuri");
            //houses
            Composite house1 = new Composite("house #1");
            street.Add(house1);
            Composite house2 = new Composite("house #2");
            street.Add(house2);
            //entrances
            Composite entrance1 = new Composite("entrance#1");
            Composite entrance2 = new Composite("entrance#1");
            Composite entrance3 = new Composite("entrance#1");
            house1.Add(entrance1);
            house1.Add(entrance2);
            house2.Add(entrance3);
            Flat fl1 = new Flat("#1", new Pet("cat", "Barsik", 5));
            Flat fl2 = new Flat("#1", new Pet("dog", "Sharik", 3));
            Flat fl3 = new Flat("#2", new Pet("cat", "Blackie", 2));
            List<Pet> pets = new List<Pet>();
            pets.Add(new Pet("dog", "Waffle", 1));
            pets.Add(new Pet("dog", "Bread", 2));
            pets.Add(new Pet("dog", "Banana", 1));
            Flat fl4 = new Flat("#4", pets);

            entrance1.Add(fl1);
            entrance2.Add(fl2);
            entrance2.Add(fl3);
            entrance3.Add(fl4);
            // Display all info
            street.Display(2);
            Console.WriteLine("Average age of pets in street: " + street.GetAverageAge());
            Console.WriteLine("Average age of pets in flat#4: " + fl4.GetAverageAge());

            Console.ReadKey();
        }
    }
}

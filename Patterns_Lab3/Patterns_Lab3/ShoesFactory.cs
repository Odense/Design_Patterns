using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab3
{
    // The 'AbstractFactory' abstract class
    abstract class ShoesFactory
    {
        public abstract MaleShoes CreateMaleShoes();
        public abstract FemaleShoes CreateFemaleShoes();
        public abstract Sneakers CreateSneakers();
    }
    // The 'ConcreteFactory1' class
    class LeatherFactory : ShoesFactory
    {
        public override MaleShoes CreateMaleShoes()
        {
            return new MaleShoes();
        }
        public override FemaleShoes CreateFemaleShoes()
        {
            return new FemaleShoes();
        }
        public override Sneakers CreateSneakers()
        {
            return new Sneakers();
        }
    }
    // The 'ConcreteFactory2' class
    class LeatheretteFactory : ShoesFactory
    {
        public override MaleShoes CreateMaleShoes()
        {
            return new MaleShoes();
        }
        public override FemaleShoes CreateFemaleShoes()
        {
            return new FemaleShoes();
        }
        public override Sneakers CreateSneakers()
        {
            return new Sneakers();
        }
    }
    // The 'ConcreteFactory3' class
    class LeatherAndFurFactory : ShoesFactory
    {
        public override MaleShoes CreateMaleShoes()
        {
            return new MaleShoes();
        }
        public override FemaleShoes CreateFemaleShoes()
        {
            return new FemaleShoes();
        }
        public override Sneakers CreateSneakers()
        {
            return new Sneakers();
        }
    }
    // The 'AbstractProduct' abstract class
    abstract class Shoes
    {
        public abstract void Deliever();
    }
    // The 'Product1' class
    class MaleShoes : Shoes
    {
        public override void Deliever()
        {
            Console.WriteLine("Male shoes was delievered");
        }
    }
    // The 'Product2' class
    class FemaleShoes : Shoes
    {
        public override void Deliever()
        {
            Console.WriteLine("Female shoes was delievered");
        }
    }
    // The 'Product3' class
    class Sneakers : Shoes
    {
        public override void Deliever()
        {
            Console.WriteLine("Sneakers was delievered");
        }
    }

    // The 'Client' class
    /*class ShoesShop
        {
            private 
        }*/
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Lab1
{
    class Pet
    {
        public string kind;
        public string name;
        public int age;

        public Pet(string kind, string name, int age)
        {
            this.kind = kind;
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return kind + " " + name + " (" + age + " years)";
        }
    }

    abstract class ResidentalComponent
    {
        protected string name;
        protected List<Pet> pets = new List<Pet>();
        protected int petsCount;
        public List<Pet> Pets
        {
            get { return pets; }
            set { pets = value; }
        }

        // Constructor
        public ResidentalComponent(string name)
        {
            this.name = name;
        }

        public abstract void Add(ResidentalComponent c);
        public abstract void Remove(ResidentalComponent c);
        public abstract int GetSumAge();
        public abstract int GetPetsCount();
        public abstract float GetAverageAge();
        public abstract void Display(int depth);
    }

    /// <summary>
    /// The 'Composite' class
    /// </summary>
    class Composite : ResidentalComponent
    {
        private List<ResidentalComponent> _children = new List<ResidentalComponent>();
        // Constructor
        public Composite(string name) : base(name)
        {

        }

        public override void Add(ResidentalComponent component)
        {
            _children.Add(component);
        }

        public override void Remove(ResidentalComponent component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            // Recursively display child nodes
            foreach (ResidentalComponent component in _children)
                component.Display(depth + 2);
        }

        public override int GetPetsCount()
        {
            this.petsCount = 0;
            foreach (ResidentalComponent component in _children)
                this.petsCount += component.GetPetsCount();
            return this.petsCount;
        }

        public override int GetSumAge()
        {
            int sumAge = 0;
            foreach (ResidentalComponent component in _children)
                sumAge += component.GetSumAge();
            return sumAge;
        }

        public override float GetAverageAge()
        {
            int sumAge = this.GetSumAge();
            int count = this.GetPetsCount();
            return count == 0 ? 0 : sumAge / count;
        }
    }

    class Flat : ResidentalComponent
    {
        public Flat(string name) : base(name)
        {
            this.petsCount = 0;
        }

        public Flat(string name, Pet pet) : base(name)
        {
            this.pets.Add(pet);
            this.petsCount = 1;
        }

        public Flat(string name, List<Pet> pets) : base(name)
        {
            this.Pets = pets;
            this.petsCount = pets.Count;
        }

        public override void Add(ResidentalComponent c)
        {
            Console.WriteLine("Impossible operation");
        }

        public override void Remove(ResidentalComponent c)
        {
            Console.WriteLine("Impossible operation");
        }

        public override void Display(int depth)
        {
            string petsInfo = "";
            foreach (Pet pet in this.pets)
            {
                petsInfo += pet.ToString();
                petsInfo += ", ";
            }
            Console.WriteLine(new String('-', depth) + name + ", pets: " + petsInfo);
        }

        public override int GetPetsCount()
        {
            return this.petsCount;
        }

        public override int GetSumAge()
        {
            int sumAge = 0;
            foreach (Pet pet in this.pets)
            {
                sumAge += pet.age;
            }
            return sumAge;
        }

        public override float GetAverageAge()
        {
            return this.pets.Count == 0 ? 0 : this.GetSumAge() / this.pets.Count;
        }
    }

}

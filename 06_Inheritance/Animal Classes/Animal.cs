using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance.Animal_Classes
{
    public enum DietType { Herbivore = 1, Omnivore, Carnivore }

    public abstract class Animal // abstract bc we don't want to instantiate it - just have other classes inherit from it.
    {
        public Animal()
        {
            Console.WriteLine("This is the Animal constructor.");
        }

        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }
        public DietType DietType { get; set; }

        public virtual void Move() // virtual to be overridden
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }
    }
}

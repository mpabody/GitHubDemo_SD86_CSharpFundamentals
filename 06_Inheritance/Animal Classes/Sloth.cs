using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance.Animal_Classes
{
    public class Sloth : Animal
    {

        public bool IsSlow
        {
            get
            {
                return true;
            }
        }

        public Sloth()
        {
            Console.WriteLine("Sloth Constructor");
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("He is slow and majestic");
        }
    }
}

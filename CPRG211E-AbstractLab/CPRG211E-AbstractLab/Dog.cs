using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_AbstractLab
{
    internal class Dog : Animal
    {
        protected string breed;

        public string Breed 
        { 
            get { return breed; } 
            set { breed = value; } 
        }

        public Dog(string breed)
        { 
            this.breed = breed; 
        }

        public override void Eat()
        {
            Console.WriteLine("Dog eats meat");
        }
    }
}

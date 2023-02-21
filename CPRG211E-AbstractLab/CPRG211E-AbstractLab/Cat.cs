using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_AbstractLab
{
    internal class Cat : Animal
    {
        protected string hairType;

        public string HairType
        { 
            get { return hairType; } 
            set { hairType = value; } 
        }

        public Cat (string hairType)
        {
            this.hairType = hairType;
        }

        public override void Eat()
        {
            Console.WriteLine("Cat eats mice");
        }
    }
}

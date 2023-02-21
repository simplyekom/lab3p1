using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_AbstractLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog;
            Console.WriteLine("Enter a dog name");
            string dogName = Console.ReadLine();

            dog = new Dog("Schnauzer");
            dog.Name = dogName;
            dog.Colour = "Brown";
            dog.Age= 3;

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Colour);
            Console.WriteLine(dog.Age);
            dog.Eat();

            Animal cat;

            Console.WriteLine("Enter a cat name");
            string catName = Console.ReadLine();

            cat = new Cat("Short");

            cat.Name = catName;
            cat.Colour = "red";
            cat.Age = 4;

            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Colour);
            Console.WriteLine(cat.Age);
            cat.Eat();

            Console.ReadLine();

        }
    }
}

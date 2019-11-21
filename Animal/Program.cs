using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] allAnimals;
            int i;

            allAnimals = new Animal[3];

            allAnimals[0] = new Cat("Kurre");
            allAnimals[1] = new Dog("Vilma");
            allAnimals[2] = new Cat("Bamse");

            i = 0;
            while (i < allAnimals.Length)
            {
                // will this work?  should it?
                Console.WriteLine("Nu kommer " + allAnimals[i].Name);

                allAnimals[i].IntroduceYourself();
                i = i + 1;
            }
            Console.ReadKey();
        }
    }
}

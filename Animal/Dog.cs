using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
            Species = SPECIES.DOG;
            CanFly = false;
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Vov. Jag är en hund som heter " + Name);
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Bird : Animal
    {
        public Bird(string name)
        {
            Name = name;
            Species = SPECIES.BIRD;
            CanFly = false;
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Piip. Jag är en fågel som heter "+Name );
        }

    }
}


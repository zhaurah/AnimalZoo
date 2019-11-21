﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Cat : Animal
    {
        public Cat(string name)
        {
            Name = name;
            Species = SPECIES.CAT;
            CanFly = false;
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Mjau. Jag är en katt som heter " + Name);
        }

    }

}

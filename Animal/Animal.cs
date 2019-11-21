using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Animal
    {
        public enum SPECIES { CAT, DOG, BIRD }

        public string Name { get; set; }
        public SPECIES Species { get; set; }
        public bool CanFly { get; set; }

        public virtual void IntroduceYourself()
        {
            Console.WriteLine("Morr.Jag är ett djur som heter "+Name);
        }
    }

}

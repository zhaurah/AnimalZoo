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

        public string name { get; set; }
        public SPECIES species { get; set; }
        public bool canFly { get; set; }

        public virtual void IntroduceYourself()
        {
            Console.WriteLine("Morr.Jag är ett djur som heter "+name);
        }
    }

}

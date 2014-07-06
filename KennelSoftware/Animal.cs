using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelSoftware
{
    class Animal
    {
        protected string name { get; set; }
        protected Enums.sex sex { get; set; }
        protected float age { get; set; }
        protected bool mixed_breed { get; set; }
        
        public override string ToString()
        {
            return this.name;
        }

        public string getAnimalName()
        {
            return name;
        }

        public bool isMixedBreed()
        {
            return mixed_breed;
        }

        public Enums.sex getAnimalSex() 
        {
            return sex;
        }

        public float getAnimalAge()
        {
            return age;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelSoftware
{
    class Animal
    {
        private string name;
        //private Enums.dogBreed breed;
        private Enums.sex sex;
        private float age;
        private bool mixed_breed;

        public Animal(string name, Enums.sex sex, bool mixed_breed, float age)
        {
            this.name = name;
            this.sex = sex;
            //this.breed = breed;
            this.mixed_breed = mixed_breed;
            this.age = age;
        }

        public override string ToString()
        {
            return this.name;
        }

        public string getAnimalName()
        {
            return this.name;
        }

        /*public Enums.dogBreed getAnimalBreed()
        {
            return this.breed;
        }*/

        public bool isMixedBreed()
        {
            return this.mixed_breed;
        }

        public Enums.sex getAnimalSex() 
        {
            return this.sex;
        }

        public float getAnimalAge()
        {
            return this.age;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelSoftware
{
    class Dog : Animal
    {
        private Enums.dogBreed breed;

        public Dog(string name, Enums.sex sex, Enums.dogBreed breed, bool mixed_breed, float age)
        {
            this.name = name;
            this.sex = sex;
            this.breed = breed; // Exclusive to dog class
            this.mixed_breed = mixed_breed;
            this.age = age;
        }

        public Enums.dogBreed getBreed()
        {
            return this.breed;
        }

        public string Cry()
        {
            return "Roof!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelSoftware
{
    class Cat : Animal
    {
        private Enums.catBreed breed;

        public Cat(string name, Enums.sex sex, Enums.catBreed breed, bool mixed_breed, float age)
        {
            this.name = name;
            this.sex = sex;
            this.breed = breed; // Exclusive to cat class
            this.mixed_breed = mixed_breed;
            this.age = age;
        }

        public Enums.catBreed getBreed()
        {
            return this.breed;
        }

        public string Cry()
        {
            return "Meow!";
        }
    }
}

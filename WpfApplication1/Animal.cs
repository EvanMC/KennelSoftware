using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Animal
    {
        private string name;
        private string breed;
        private float age;

        public Animal(string name, string breed, float age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }

        public string getAnimalName()
        {
            return this.name;
        }

        public string getAnimalBreed()
        {
            return this.breed;
        }

        public float getAnimalAge()
        {
            return this.age;
        }
    }
}

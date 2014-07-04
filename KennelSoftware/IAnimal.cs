using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelSoftware
{
    interface IAnimal
    {
        private string name { get; set; }
        private float age { get; set; }
        private bool mixed { get; set; }
        private Enums.sex sex { get; set; }

        public string getName();
        public float getAge();
        public bool isMixed();
        public Enums.sex getSex();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelSoftware
{
    class Customer
    {
        private string customer_fname, customer_lname;
        private List<Animal> animal;

        public Customer(string fname, string lname)
        {
            customer_fname = "";
            customer_lname = "";
            animal = new List<Animal>();
        }

        public string getCustomerFirstName()
        {
            return customer_fname;
        }

        public string getCustomerLastName()
        {
            return customer_lname;
        }
    }
}

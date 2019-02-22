using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    class Toppings : Pizza
    {
        protected string[] toppingsList = { "chicken" };
        public Toppings():base()
        {
        }

        protected void ShowToppings()
        {
            //display all the toppings and call the select toppings function
        }

        private void SelectToppings()
        {
            //this function selects the topping choice and adds it in the base class orderSpecification;
        }
    }
}

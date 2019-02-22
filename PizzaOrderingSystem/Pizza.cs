using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    class Pizza
    {
        protected string[] vegPizzaList = { "Peppy Paneer", "Margherita" };
        protected string[] nonVegPizzaList = { "Pepper Barbeque Chicken", "Chicken Tikka" };

        protected OrderSpecification order;
        public Pizza()
        {
            order = new OrderSpecification();
        }
        protected void ShowPizza()
        {
            //display the list of veg and non veg pizza;
            //this call the select pizza function within the show pizza;
        }

        private void SelectPizzaBase()
        {
            //place the  base pizza choice in the orderspecification object;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    class Order:Toppings
    {
        private int orderId;

        public int OrderId { get => orderId; set => orderId = value; }

        public void CreateOrder()
        {
            //calls the show pizza ,show toppings function 
        }

    }
}

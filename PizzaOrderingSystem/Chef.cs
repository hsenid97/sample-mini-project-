using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    class Chef:Person
    {
        public Chef(int id,string userName)
        {
            base.id = id;
            base.userName = userName;
        }

        public bool CookOrder(OrderSpecification order)
        {
            // make necessary process and function call in the cook order function
            // then call the function delever order function passing order object
            
            return true;
        }

        private void DeliverOrder(OrderSpecification order)
        {
            //deliver the order to the  customer id based on the orderspecifiation object.
        }
    }
}

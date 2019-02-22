using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    class Manager : Person
    {
        private int managerExperience;

        public Manager(int id, string userName, string phoneNumber, string emailId,int managerExperience)
        {
            base.id = id;
            base.userName = userName;
            base.phoneNumber = phoneNumber;
            base.emailId = emailId;
            this.managerExperience = managerExperience; 
        }

        
        public bool AcceptOrder(OrderSpecification order)
        {

            //Accept the order from the customer 
            //Call the compute cost method and the call the prepare order function
            return true;
        }

        public int ComputeCostOfOrder(OrderSpecification order)
        {
            //Get the orderSpec object and calculate the cost of the pizza and return the cost
            return 0;
        }

        public void PrepareOrder(OrderSpecification order)
        {
            //call the chefs cook order function to prepare the food
        }

    }
}

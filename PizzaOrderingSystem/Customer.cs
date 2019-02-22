using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    class Customer:Person,ICustomerAction
    {
        private OrderSpecification orderSpec = null;

        // polymorphism overloading (acheived through constructor overloading)
        public Customer(int id, string userName, string phoneNumber)
        {
            base.id = id;
            base.userName = userName;
            base.phoneNumber = phoneNumber;
            orderSpec = new OrderSpecification();
        }
        public Customer(int id,string userName,string phoneNumber,string emailId)
        {
            base.id = id;
            base.userName = userName;
            base.phoneNumber = phoneNumber;
            base.emailId = emailId;
            orderSpec = new OrderSpecification();
        }

        public void ShowCustomerDetails()
        {
            //Display the details of the logged in customer
        }

        public void PlaceOrder()
        {
            // Call the Functions of the Order class and pass the orderSpec object to get the order;
            ExceptionHandler.OrderAcceptenceFailure();
        }
        public void AcceptDelevery()
        {
            //Accept the Delevery from the chef ;
            ExceptionHandler.DeliveryFailedException();
        }
        private void MakePayment()
        {
            
            //Make Payment by using the user credentials or cod;
        }
        public void CancelOrder()
        {
            //Cancel the order by calling the action in the manager class;
        }
    }
}

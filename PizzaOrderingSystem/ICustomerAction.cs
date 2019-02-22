using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    interface ICustomerAction
    {
        void PlaceOrder();
        void AcceptDelevery();
        void CancelOrder();
    }
}

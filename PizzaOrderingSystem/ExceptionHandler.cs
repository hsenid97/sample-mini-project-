using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    static class ExceptionHandler
    {
        public static void DeliveryFailedException()
        {
            Console.WriteLine("The delivery has been failed  due to internal error");
        }

        public static void OrderAcceptenceFailure()
        {
            Console.WriteLine("Pizza Hut has not accepted your order please reorder your pizza again");
        }
    }
}

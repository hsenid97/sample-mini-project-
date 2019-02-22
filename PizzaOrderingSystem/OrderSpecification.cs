using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    class OrderSpecification
    {

        private int sizeChoice;
        private int basePizzaChoice;
        private int toppingChoice;
        private int customerId;

        public int SizeChoice { get => sizeChoice; set => sizeChoice = value; }
        public int BasePizzaChoice { get => basePizzaChoice; set => basePizzaChoice = value; }
        public int ToppingChoice { get => toppingChoice; set => toppingChoice = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
    }
}

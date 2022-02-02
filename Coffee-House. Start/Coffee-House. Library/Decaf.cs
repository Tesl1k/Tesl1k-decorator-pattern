using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_House.Library
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Кофу без кофеина";
            Price = 1.39;
        }

        public override double Cost()
        {
            return Price;
        }
    }
}

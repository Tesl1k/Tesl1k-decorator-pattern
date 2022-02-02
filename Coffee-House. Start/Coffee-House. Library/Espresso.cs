using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_House.Library
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Эспрессо";
            Price = 1.69;
        }

        public override double Cost()
        {
            return Price;
        }
    }
}

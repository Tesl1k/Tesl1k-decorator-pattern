using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_House.Library
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Кофу темной обжарки";
            Price = 1.99;
        }

        public override double Cost()
        {
            return Price;
        }
    }
}

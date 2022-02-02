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
            description = "Кофе темной обжарки";
            Price = 1.99;
        }

        public override string getDescription()
        {
            return description;
        }

        public override double Cost()
        {
            return Price;
        }
    }
}

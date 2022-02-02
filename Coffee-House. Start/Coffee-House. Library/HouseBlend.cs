using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_House.Library
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "Хаусбрандт";
            Price = 2.39;

        }

        public override double Cost()
        {
            return Price;
        }
    }
}

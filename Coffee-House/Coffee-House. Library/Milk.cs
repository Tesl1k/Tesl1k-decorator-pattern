using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_House.Library
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage;        

        double milk = 0.39;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return $"{beverage.getDescription()} + молоко";
        }
        public override double Cost()
        {
            return milk + beverage.Cost();
        }
    }
}

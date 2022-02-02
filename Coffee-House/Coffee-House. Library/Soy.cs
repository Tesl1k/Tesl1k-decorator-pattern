using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_House.Library
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        double soy = 0.29;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + " + соя";
        }
        public override double Cost()
        {
            return soy + beverage.Cost();
        }
    }
}

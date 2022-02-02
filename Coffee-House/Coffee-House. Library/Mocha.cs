using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_House.Library
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        double mocha = 0.20;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + " + шоколад";
        }
        public override double Cost()
        {
            return mocha + beverage.Cost();
        }
    }
}

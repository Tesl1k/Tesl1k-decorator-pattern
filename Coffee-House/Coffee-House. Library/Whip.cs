using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_House.Library
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        double whip = 0.10;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + " + сливки";
        }
        public override double Cost()
        {
            return whip + beverage.Cost();
        }
    }
}

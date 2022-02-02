using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_House.Library
{
    public abstract class Beverage
    {
        protected string description;

        double milk = 0.39;
        double soy = 0.29;
        double mocha = 0.20;
        double whip = 0.10;

        public double Price { get; set; }
        public string Description
        {
            get
            {
                return description;
            }
        }

        abstract public double Cost();
        
        public string setMilk()
        {
            return $"{description += " + молоко"}: {Price += milk}";
        }

        

        public string setSoy()
        {

            return $"{description += " + соя"}: {Price += soy}";
        }

        public string setMocha()
        {
            return $"{description += " мокко"}: {Price += mocha}";

        }


        public string setWhip()
        {
            return $"{description += " + взбитые сливки"}: {Price += whip}";

        }

    }
}

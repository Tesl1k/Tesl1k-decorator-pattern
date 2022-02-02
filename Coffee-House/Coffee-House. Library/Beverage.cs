using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_House.Library
{
    public abstract class Beverage
    {
        protected string description = "nothing";

        protected double Price { get; set; }
        

        //public string getDescription()
        //{
        //    return description;
        //}

        abstract public string getDescription();

        abstract public double Cost();
        

    }
}

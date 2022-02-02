using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_House.Library;

namespace Coffee_House.Start
{
    class Program
    {
        static void Main(string[] args)
        {
            DarkRoast darkRoast = new DarkRoast();
            Decaf decaf = new Decaf();
            Espresso espresso = new Espresso();
            HouseBlend houseBlend = new HouseBlend();



            Console.WriteLine(darkRoast.Description + ": " + darkRoast.Cost());
            Console.WriteLine(darkRoast.setMilk());
            Console.WriteLine(darkRoast.setSoy());
            Console.WriteLine();

            Console.WriteLine(decaf.Description + ": " + decaf.Cost());
            Console.WriteLine(decaf.setSoy());
            Console.WriteLine();

            Console.WriteLine(espresso.Description + ": " + espresso.Cost());
            Console.WriteLine(espresso.setMocha());
            Console.WriteLine(espresso.setWhip());
            Console.WriteLine();

            Console.WriteLine(houseBlend.Description + ": " + houseBlend.Cost());
            Console.WriteLine(houseBlend.setSoy());
            Console.WriteLine(houseBlend.setWhip());

            Console.ReadKey();
        }
    }
}

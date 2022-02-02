using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_House.Library;

namespace Coffee_House
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Beverage darkRoast = new DarkRoast();
            Beverage decaf = new Decaf();
            Beverage espresso = new Espresso();
            Beverage houseBlend = new HouseBlend();


            Console.WriteLine($"{darkRoast.getDescription()} \nСтоимость: {darkRoast.Cost()}");
            Console.WriteLine($"{decaf.getDescription()} \nСтоимость: {decaf.Cost()}");
            Console.WriteLine($"{espresso.getDescription()} \nСтоимость: {espresso.Cost()}");
            Console.WriteLine($"{houseBlend.getDescription()} \nСтоимость: {houseBlend.Cost()}");


            darkRoast = new Milk(darkRoast);

            Console.WriteLine($"{darkRoast.getDescription()} \nСтоимость: {darkRoast.Cost()}");

            darkRoast = new Mocha(darkRoast);


            decaf = new Whip(decaf);

            espresso = new Mocha(espresso);

            Console.WriteLine($"{espresso.getDescription()} \nСтоимость: {espresso.Cost()}");

            espresso = new Soy(espresso);

            houseBlend = new Milk(houseBlend);

            Console.WriteLine($"{houseBlend.getDescription()} \nСтоимость: {houseBlend.Cost()}");

            houseBlend = new Whip(houseBlend);

            Console.WriteLine($"{darkRoast.getDescription()} \nСтоимость: {darkRoast.Cost()}");
            Console.WriteLine($"{decaf.getDescription()} \nСтоимость: {decaf.Cost()}");
            Console.WriteLine($"{espresso.getDescription()} \nСтоимость: {espresso.Cost()}");
            Console.WriteLine($"{houseBlend.getDescription()} \nСтоимость: {houseBlend.Cost()}");






            Console.ReadKey();
        }
    }
}

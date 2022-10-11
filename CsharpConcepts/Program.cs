using CsharpConcepts.Generics;
using CsharpConcepts.VirtualAndOverride;
using System;

namespace CsharpConcepts
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
             * Virtual, Abstract and Override example
            */
            //double taxiCost = 12.5, busCost = 10.0, subwayCost = 5.0;
            //double busCostPerKm = 2.7, taxiCostPerKm = 1.85, taxiCostPerMinute = 0.75;
            //double tripDistanceInKm = 8.6, tripTimeInMinutes = 30;
            //string route = "Metro Muzquiz - Metro Oceanía";

            //Bus busTrip = new Bus(busCost, busCostPerKm, tripDistanceInKm);
            //busTrip.Route = route;
            //Subway subwayTrip = new Subway(subwayCost);
            //subwayTrip.Route = route;
            //Taxi taxiTrip = new Taxi(taxiCost, taxiCostPerKm, tripDistanceInKm, taxiCostPerMinute, tripTimeInMinutes);
            //taxiTrip.Route = null;
            //Console.WriteLine("Bus trip info: Route {0} | Cost: {1:F2}", busTrip.Route, busTrip.Charge());
            //Console.WriteLine("Subway trip info: Route {0} | Cost: {1:F2}", subwayTrip.Route, subwayTrip.Charge());
            //Console.WriteLine("Taxi trip info: Route {0} | Cost: {1:F2}", taxiTrip.Route, taxiTrip.Charge());

            //busTrip.GetCost();
            //taxiTrip.GetCost();
            //subwayTrip.GetCost();

            /*
             * Generics example
            */
            ComparisonGenericClass<int> comparison = new ComparisonGenericClass<int>();
            int value1 = 4, value2 = 19;
            comparison.ShowWelcomeMessage();
            Console.WriteLine($"Are the values {value1.ToString()} and {value2.ToString()} equals? {comparison.CompareValues(value1, value2)} \n");

            Console.WriteLine("This are the initial value of value1 {0}", value1.ToString());
            Console.WriteLine("This are the initial value of value2 {0}\n", value2.ToString());

            comparison.Swap(ref value1, ref value2);

            Console.WriteLine("This are the final value of value1 after swap {0}", value1.ToString());
            Console.WriteLine("This are the final value of value2 after swap {0}\n", value2.ToString());


            ComparisonGenericClass<string> comparison2 = new ComparisonGenericClass<string>();
            string value3 = "Hola", value4 = "hola";
            comparison2.ShowWelcomeMessage();
            Console.WriteLine($"Are the values {value3.ToString()} and {value4.ToString()} equals? {comparison2.CompareValues(value3, value4)}\n");

            Console.WriteLine("This are the initial value of value3 {0}", value3.ToString());
            Console.WriteLine("This are the initial value of value4 {0}\n", value4.ToString());

            comparison2.Swap(ref value3, ref value4);

            Console.WriteLine("This are the final value of value3 after swap {0}", value3.ToString());
            Console.WriteLine("This are the final value of value4 after swap {0}\n", value4.ToString());

        }
    }
    
}

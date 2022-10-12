using CsharpConcepts.AnonymousTypes;
using CsharpConcepts.Delegates;
using CsharpConcepts.ExtensionMethod;
using CsharpConcepts.Generics;
using CsharpConcepts.Reflection;
using CsharpConcepts.VirtualAndOverride;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static CsharpConcepts.Delegates.DelegatesExample;

namespace CsharpConcepts
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
             * Virtual, Abstract and Override example
            */
            #region Virtual, Abstract and Override

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
            #endregion

            /*
             * Generics example
            */
            #region Generics 

            //ComparisonGenericClass<int> comparison = new ComparisonGenericClass<int>();
            //int value1 = 4, value2 = 19;
            //comparison.ShowWelcomeMessage();
            //Console.WriteLine($"Are the values {value1.ToString()} and {value2.ToString()} equals? {comparison.CompareValues(value1, value2)} \n");

            //Console.WriteLine("This are the initial value of value1 {0}", value1.ToString());
            //Console.WriteLine("This are the initial value of value2 {0}\n", value2.ToString());

            //comparison.Swap(ref value1, ref value2);

            //Console.WriteLine("This are the final value of value1 after swap {0}", value1.ToString());
            //Console.WriteLine("This are the final value of value2 after swap {0}\n", value2.ToString());


            //ComparisonGenericClass<string> comparison2 = new ComparisonGenericClass<string>();
            //string value3 = "Hola", value4 = "hola";
            //comparison2.ShowWelcomeMessage();
            //Console.WriteLine($"Are the values {value3.ToString()} and {value4.ToString()} equals? {comparison2.CompareValues(value3, value4)}\n");

            //Console.WriteLine("This are the initial value of value3 {0}", value3.ToString());
            //Console.WriteLine("This are the initial value of value4 {0}\n", value4.ToString());

            //comparison2.Swap(ref value3, ref value4);

            //Console.WriteLine("This are the final value of value3 after swap {0}", value3.ToString());
            //Console.WriteLine("This are the final value of value4 after swap {0}\n", value4.ToString());


            /*
             * Extension Method example
            */
            //int number = 5;
            //double numberPowered = number.MyOwnPower(3);
            ////Method invoked like other static methods
            ////double numberPowered = ExtensionMethods.MyOwnPower(number, 3);
            //Console.WriteLine(numberPowered);

            //string word = "Aeropuertos";
            //Console.WriteLine($"This is your word {word}");
            //Console.WriteLine($"This is your word in F language {word.CastWord2FLanguage()}");
            #endregion


            /*
             * Delegates example 
            */
            #region Delegates

            //DelegatesExample delegatesObj = new DelegatesExample();

            ////Classic creation
            //NotifyDelegate notifyDelegateClassic = new NotifyDelegate(delegatesObj.Notify);
            //notifyDelegateClassic("Richie");

            ////New way of creation
            //NotifyDelegate notifyDelegateNewWay = delegatesObj.Notify;
            //notifyDelegateNewWay("Nefta");

            ////Anonymous Method
            //NotifyDelegate notifyDelegateAnonymous = delegate (string message)
            //{ 
            //    Console.WriteLine($"Mensaje recibido: {message} \n");
            //};
            //notifyDelegateAnonymous("Hola, ¿cómo estás?");

            ////Anonymous Method with Lambda
            //NotifyDelegate notifyDelegateLambda = message => 
            //{ 
            //    Console.WriteLine($"Received message: {message} \n"); 
            //};
            //notifyDelegateLambda("Hi, how are you?");

            ////Callback
            //NotifyDelegate notifyDelegateCallback = delegatesObj.Notify;
            //NotifyWithCallback("Pao", notifyDelegateCallback);

            ////Multicast 
            //NotifyDelegate notifyDelegateEng, notifyDelegateSpa, notifyDelegateMultiCast, notifyDelegateMultiCastMinusEng;

            //notifyDelegateEng = delegatesObj.Notify;
            //notifyDelegateSpa = delegatesObj.NotifyESP;
            //notifyDelegateMultiCast = notifyDelegateEng + notifyDelegateSpa;
            //notifyDelegateMultiCastMinusEng = notifyDelegateMultiCast - notifyDelegateEng;

            //Console.WriteLine("Invoking delegate notifyDelegateEng:");
            //notifyDelegateEng("Pao");
            //Console.WriteLine("Invoking delegate notifyDelegateSpa:");
            //notifyDelegateSpa("Rubi");
            //Console.WriteLine("Invoking delegate notifyDelegateMultiCast:");
            //notifyDelegateMultiCast("Carlos");
            //Console.WriteLine("Invoking delegate notifyDelegateMultiCastMinusEng:");
            //notifyDelegateMultiCastMinusEng("Dalia");
            #endregion

            /*
             * Anonymous Types example 
            */
            #region Anonymous Types

            // Anonymous Array 
            //var beers = new[]
            //{ 
            //    new { Id = 1, Name = "Bohemia", TypeOfBeer = "Dark" },
            //    new { Id = 2, Name = "Corona", TypeOfBeer = "Light" },
            //    new { Id = 3, Name = "Guinness", TypeOfBeer = "Dark" }
            //};

            //var bohemia = beers[0] with { TypeOfBeer = "Ligth" };  

            //Console.WriteLine("These are our available beers\n");
            //foreach (var beer in beers)
            //{
            //    Console.WriteLine($"Name: {beer.Name} | TypeOfBeer: {beer.TypeOfBeer}");
            //}


            //beers[0] = bohemia;
            //Console.WriteLine("\n These are our new available beers\n");
            //foreach (var beer in beers)
            //{
            //    Console.WriteLine($"Name: {beer.Name} | TypeOfBeer: {beer.TypeOfBeer}");
            //}

            //List<Freestyler> freestylers = new List<Freestyler>()
            //{
            //    new Freestyler()
            //    {
            //        Id = 1, AKA = "Aczino", BoardPosition = 1, League = "MEX", Points = 25
            //    },
            //    new Freestyler()
            //    {
            //        Id = 2, AKA = "Larrix", BoardPosition = 1, League = "ARG", Points = 20
            //    },
            //    new Freestyler()
            //    {
            //        Id = 3, AKA = "RC", BoardPosition = 2, League = "MEX", Points = 18
            //    },
            //    new Freestyler()
            //    {
            //        Id = 4, AKA = "Dtoke", BoardPosition = 2, League = "ARG", Points = 18
            //    },
            //    new Freestyler()
            //    {
            //        Id = 5, AKA = "Chuty", BoardPosition = 1, League = "SPA", Points = 23
            //    },
            //    new Freestyler()
            //    {
            //        Id = 6, AKA = "Sara Socas", BoardPosition = 2, League = "SPA", Points = 21
            //    }
            //};

            //var mexicanFreestylers = freestylers.Where(x => x.League == "MEX")
            //                        .Select(z => new { Name = z.AKA, z.BoardPosition }).OrderBy(x => x.BoardPosition);

            //Console.WriteLine("\nThese are all Freestylers\n");
            //foreach (Freestyler freestyler in freestylers)
            //{
            //    Console.WriteLine($"AKA: {freestyler.AKA} | BoardPosition: {freestyler.BoardPosition} | League: {freestyler.League} | Points: {freestyler.Points}");
            //}

            //Console.WriteLine("\nThese are Mexican Freestylers\n");
            //foreach (var freestyler in mexicanFreestylers)
            //{
            //    Console.WriteLine($"Name: {freestyler.Name} | BoardPosition: {freestyler.BoardPosition}");
            //}

            #endregion

            /*
            * Reflection example 
            */
            #region Reflection

            // Using GetType to obtain type information:
            int i = 42;
            Type type = i.GetType();
            Console.WriteLine(type);

            // Using Reflection to get information of an Assembly:
            Assembly info = typeof(int).Assembly;
            Console.WriteLine(info);

            Person person = new Person()
            {
                Name = "Ricardo",
                Age = 26
            };

            Professional professional = new Professional()
            {
                Name = "Ricardo",
                Title = "Engineer"
            };

            //IReflection reflection = person;
            IReflection reflection = professional;

            System.Reflection.PropertyInfo[] properties = reflection.GetType().GetProperties();

            Console.WriteLine($"\nThis is the type of your object {reflection.GetType()}");
            foreach(var property in properties)
            {
                Console.WriteLine($"{property.Name} : {property.GetValue(reflection)}");
            }

            #endregion
        }
    }
    
}

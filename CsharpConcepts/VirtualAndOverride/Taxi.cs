using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpConcepts.VirtualAndOverride
{
    public class Taxi: PublicTransport
    {
        public override string Route
        {
            get 
            {
                return base.Route;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    base.Route = value;
                }
                else
                {
                    base.Route = "Dynamic Route";
                }
            }
        }
        public Taxi()
        {
        }

        public Taxi(double cost, double costPerkm, double tripDistanceInKm, double costPerMinute, double tripTimeInMinutes) : base(cost, costPerkm, tripDistanceInKm, costPerMinute, tripTimeInMinutes)
        {
        }

        public override double Charge()
        {
            return Cost + (CostPerKm * TripDistanceInKm) + (CostPerMinute * TripTimeInMinutes);
        }

        public override void GetCost()
        {
            Console.WriteLine("The cost of Taxi is {0}", Cost);
        }
    }
}

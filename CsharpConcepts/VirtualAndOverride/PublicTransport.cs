using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpConcepts.VirtualAndOverride
{
    public abstract class PublicTransport
    {
        public double Cost { get; set; }
        public virtual string Route { get; set; }
        public virtual double CostPerKm { get; set; }
        public virtual double CostPerMinute { get; set; }
        public virtual double TripDistanceInKm { get; set; }
        public virtual double TripTimeInMinutes { get; set; }
        public PublicTransport()
        {
        }

        public PublicTransport(double cost, double costPerKm, double tripDistanceInKm, double costPerMinute, double tripTimeInMinutes)
        {
            Cost = cost;
            CostPerKm = costPerKm;
            TripDistanceInKm = tripDistanceInKm;
            CostPerMinute = costPerMinute;
            TripTimeInMinutes = tripTimeInMinutes;
        }

        public virtual double Charge()
        {
            return Cost;
        }

        public abstract void GetCost();
    }
}

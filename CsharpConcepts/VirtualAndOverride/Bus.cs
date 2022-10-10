using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpConcepts.VirtualAndOverride
{
    public class Bus: PublicTransport
    {
        public Bus()
        {
        }

        public Bus(double cost, double costPerkm, double tripDistanceInKm) : base(cost, costPerkm, tripDistanceInKm, 0.0, 0.0)
        {
        }

        public override double Charge()
        {
            return Cost + (CostPerKm * TripDistanceInKm) ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CsharpConcepts.VirtualAndOverride
{
    public class Subway: PublicTransport
    {
        public Subway()
        {
        }

        public Subway(double cost) : base(cost,0.0,0.0,0.0,0.0)
        {
        }

        public override void GetCost()
        {
            Console.WriteLine("The cost of Subway is {0}", Cost);
        }
    }
}

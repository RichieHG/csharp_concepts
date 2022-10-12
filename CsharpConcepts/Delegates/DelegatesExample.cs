using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcepts.Delegates
{
    public class DelegatesExample
    {
        public delegate void NotifyDelegate(string str);

        public void Notify(string name)
        {
            Console.WriteLine($"Message from: {name} \n");
        }

        public void NotifyESP(string name)
        {
            Console.WriteLine($"Mensaje de: {name} \n");
        }

        public static void NotifyWithCallback(string str, NotifyDelegate notifyDelegate)
        {
            notifyDelegate(str);
        }
    }
}

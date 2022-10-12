using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcepts.Reflection
{
    public class Person : IReflection
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

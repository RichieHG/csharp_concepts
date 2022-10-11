using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpConcepts.Generics
{
    public class ComparisonGenericClass<T>
    {

        public bool CompareValues(T value1, T value2)
        {
            return value1.Equals(value2);
        }

        public void ShowWelcomeMessage()
        {
            Console.WriteLine("Hi, this is a class to compare this type of data: {0}", typeof(T).ToString());
        }

        public void Swap(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}

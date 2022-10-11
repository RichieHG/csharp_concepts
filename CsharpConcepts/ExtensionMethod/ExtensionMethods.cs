using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpConcepts.ExtensionMethod
{
    public static class ExtensionMethods
    {
        public static double MyOwnPower(this int number, int power) 
        {
            double temp = 1;
            for(int i = 1; i<=power; i++)
            {
                temp = temp * number;
            }
            return temp;
        }

        public static string CastWord2FLanguage(this string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int startIndexTemp = 0, lengthTemp = 1;

            string wordInF = "";
            foreach(char letter in word)
            {   
                if (vowels.Contains(letter))
                {
                    string split = word.Substring(startIndexTemp, lengthTemp);
                    wordInF = wordInF + split + "f" + split.ToLower().Last();
                    startIndexTemp = startIndexTemp + lengthTemp;
                    lengthTemp = 0;
                }
                else if (startIndexTemp + lengthTemp == word.Length)
                {
                    string split = word.Substring(startIndexTemp, lengthTemp);
                    wordInF = wordInF + split;
                }

                lengthTemp++;
            }
            return wordInF;
        }
    }
}

using System;
using System.Collections.Generic;

namespace NumeralSystemsConversion.Converter
{
    public class NumeralConverter
    {
        public void test(){
            var dict = new Dictionary<int, string>(){

                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"}
            };

            var x = dict.Keys;
            Console.WriteLine(x);
        }
    }
}

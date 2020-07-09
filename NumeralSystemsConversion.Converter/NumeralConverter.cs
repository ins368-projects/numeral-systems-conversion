using System;
using System.Collections.Generic;

namespace NumeralSystemsConversion.Converter
{
    public class NumeralConverter
    {
        static Dictionary<char, int> romanChars = new Dictionary<char, int>
        {
           {'M', 1000},
           {'D', 500},
           {'C', 100},
           {'L', 50},
           {'X', 10},
           {'V', 5},
           {'I', 1}
       };

       public static int RomanToArab(string romanNumber) {


            int RomanLength = romanNumber.Length;
            int result = 0;
            int consecutive = 1;

            for (int i = 0; i < RomanLength; i++)
            {
                romanChars.TryGetValue(romanNumber[i], out int curr_value);

                if ( i < RomanLength - 1)
                {
                    romanChars.TryGetValue(romanNumber[i + 1], out int next_val);

                    if (curr_value == next_val)
                        consecutive++;
                    else
                        consecutive = 1;

                    if (consecutive > 3) return -1;

                    result += curr_value;

                }
                else
                {
                    result += curr_value;
                   
                }
           


            }

           


            return result;
       }

    }
}

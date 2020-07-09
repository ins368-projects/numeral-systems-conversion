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
           romanNumber = romanNumber.ToUpper().Replace(" ","");
            int RomanLength = romanNumber.Length;
            int result = 0;
            int consecutive = 1;

            for (int i = 0; i < RomanLength; i++)
            {
                romanChars.TryGetValue(romanNumber[i], out int curr_value);

                if (i < RomanLength - 1)
                {
                    romanChars.TryGetValue(romanNumber[i + 1], out int next_val);
                     
                    if(next_val == 0) return -1;

                    if (curr_value == next_val) 
                      consecutive++;

                    else
                       consecutive = 1;

                    if (consecutive > 3) return -1;

                    if(consecutive > 1 && (curr_value == 5 || curr_value == 50 || curr_value == 500)) return -1;

                    if(next_val > curr_value){
                        result += next_val - curr_value;
                        i++;
                    }
                    else{
                        result += curr_value;
                    }
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


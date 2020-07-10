using System;
using System.Collections.Generic;

namespace NumeralSystemsConversion.Converter
{
    /// <summary>
    ///     Hold methods to convert numbers between Hindu-Arabic and roman numeral system .
    /// </summary>
    static public class NumeralConverter
    {
        /// <summary>
        ///     Convert an hindu-arabic number to the roman numeral system.
        /// </summary>
        /// <param name="hinduArabicNumber">The hindu-arabic number to be converted</param>
        /// <returns>
        ///     The indicated number in roman numeral system.
        /// </returns>
        static public string HinduArabicToRoman(int hinduArabicNumber)
        {
            if (hinduArabicNumber > 3999 || hinduArabicNumber < 1)
            {
                throw new IndexOutOfRangeException("Roman number needs to be between 1 and 3999");
            }

            int[] nums = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romanNums = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            string romanNum = "";
            int x = 0;
            while (hinduArabicNumber > 0)
            {
                int limit = hinduArabicNumber / nums[x];
                for (int i = 0; i < limit; i++)
                {
                    romanNum += romanNums[x];
                    hinduArabicNumber -= nums[x];
                }
                x++;
            }

            return romanNum;
        }

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

        /// <summary>
        ///     Convert a ruman number to the hindu-arabic numeral system.
        /// </summary>
        /// <param name="romanNumber">The number in roman numeral system to be converted</param>
        /// <returns>
        ///     The indicated number in hindu-arabic numeral system.
        /// </returns>
       public static int RomanToHinduArabic(string romanNumber) {
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


using System;
using System.Collections.Generic;

namespace NumeralSystemsConversion.Converter
{
    static public class NumeralConverter
    {
        static public string IntToRoman(int num)
        {
            if (num > 3999 || num < 1)
            {
                throw new IndexOutOfRangeException("Roman number needs to be between 1 and 3999");
            }

            int[] nums = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romanNums = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            string romanNum = "";
            int x = 0;
            while (num > 0)
            {
                int limit = num / nums[x];
                for (int i = 0; i < limit; i++)
                {
                    romanNum += romanNums[x];
                    num -= nums[x];
                }
                x++;
            }

            return romanNum;
        }
    }
}

using System;
using System.Collections.Generic;

namespace NumeralSystemsConversion.Converter
{
    static public class NumeralConverter
    {
        static public string IntToRoman(int num){
            if (num > 3999 || num < 1){
                throw new IndexOutOfRangeException("Roman number needs to be between 1 and 3999");
            }

            int[] nums = {5, 1};
            string[] romanNums = {"V", "I"};

            string romanNum = "";
            int x = 0;
            while(num > 0){
                for (int i = 0; i < num / nums[x]; i++)
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

using System;
using Xunit;
using NumeralSystemsConversion.Converter;

namespace NumeralSystemsConversion.Tests
{
    public class NumeralConverterUnitTests
    {
      // ARAB TO ROMAN
        [Fact]
        public void Int1ReturnsRomanI()
        {
            Assert.Equal("I", NumeralConverter.HinduArabicToRoman(1));
        }

        [Fact]
        public void IntOverRomanRange()
        {
            Assert.Throws<IndexOutOfRangeException>(() => NumeralConverter.HinduArabicToRoman(4000));
        }

        [Fact]
        public void IntUnderRomanRange()
        {
            Assert.Throws<IndexOutOfRangeException>(() => NumeralConverter.HinduArabicToRoman(0));
        }

        [Fact]
        public void Int2ReturnsRomanII()
        {
            Assert.Equal("II", NumeralConverter.HinduArabicToRoman(2));
        }

        [Fact]
        public void Int5ReturnsRomanV()
        {
            Assert.Equal("V", NumeralConverter.HinduArabicToRoman(5));
        }

        [Fact]
        public void Int10ReturnsRomanX()
        {
            Assert.Equal("X", NumeralConverter.HinduArabicToRoman(10));
        }

        [Fact]
        public void Int4ReturnsRomanIV()
        {
            Assert.Equal("IV", NumeralConverter.HinduArabicToRoman(4));
        }

        [Fact]
        public void Int400ReturnsRomanCD()
        {
            Assert.Equal("CD", NumeralConverter.HinduArabicToRoman(400));
        }

        [Fact]
        public void Int48ReturnsRomanXLVIII()
        {
            Assert.Equal("XLVIII", NumeralConverter.HinduArabicToRoman(48));
        }

        [Fact]
        public void Int498ReturnsRomanCDXCVIII()
        {
            Assert.Equal("CDXCVIII", NumeralConverter.HinduArabicToRoman(498));
        }

        [Fact]
        public void Int1021ReturnsRomanMXXI()
        {
            Assert.Equal("MXXI", NumeralConverter.HinduArabicToRoman(1021));
        }
        [Fact]
        public void Int2020ReturnsRomanMMXX()
        {
            Assert.Equal("MMXX", NumeralConverter.HinduArabicToRoman(2020));
        }

        [Fact]
        public void NegativeIntReturnsError()
        {
            Assert.Throws<IndexOutOfRangeException>(() => NumeralConverter.HinduArabicToRoman(-20));
        }

        [Fact]
        public void Int10000ReturnsError()
        {
            Assert.Throws<IndexOutOfRangeException>(() => NumeralConverter.HinduArabicToRoman(10000));
        }
      
      //ROMAN TO ARAB
            
        public void RomanToArab_InputIII_Return3()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("III");
            Assert.Equal(3, arabic);
        }

        [Fact]
        public void RomanToArab_InputV_Return5()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("V");
            Assert.Equal(5, arabic);
        }

        [Fact]
        public void RomanToArab_InputIIII_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("IIII");
            Assert.Equal(-1, arabic);
        }

        [Fact]
        public void RomanToArab_InputMoreThanThreeEqualNumbers_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("XXXX");
            Assert.Equal(-1, arabic);
        }

        [Fact]
        public void RomanToArab_InputRepetitionOfV_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("VV");
            Assert.Equal(-1, arabic);
        }

        [Fact]
        public void RomanToArab_InputRepetitionOfL_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("LL");
            Assert.Equal(-1, arabic);
        }
        [Fact]
        public void RomanToArab_InputRepetitionOfD_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("DDD");
            Assert.Equal(-1, arabic);
        }

        [Fact]
        public void RomanToArab_InputXXV_Return25()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("XXV");
            Assert.Equal(25, arabic);
        }

        [Fact]
        public void RomanToArab_InputIX_Return9()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("IX");
            Assert.Equal(9, arabic);
        }

        [Fact]
        public void RomanToArab_InputInLowerCasexxiv_Return24()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("xxiv");
            Assert.Equal(24, arabic);
        }

        [Fact]
        public void RomanToArab_InputWithSpacesVII_I_Return19()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("XI X");
            Assert.Equal(19, arabic);
        }

        [Fact]
        public void RomanToArab_InputIsNonValidLetter_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("VAA");
            Assert.Equal(-1, arabic);
        }

        [Fact]
        public void RomanToArab_InputMMMM_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("MMMM");
            Assert.Equal(-1, arabic);
        }

        [Fact]
        public void RomanToArab_InputMMMCMXCIX_Return3999()
        {
            var arabic = NumeralConverter.RomanToHinduArabic("MMMCMXCIX");
            Assert.Equal(3999, arabic);
        }
    }
}

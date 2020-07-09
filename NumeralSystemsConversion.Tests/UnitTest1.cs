using System;
using Xunit;
using NumeralSystemsConversion.Converter;

namespace NumeralSystemsConversion.Tests
{
    public class NumeralConverterUnitTests
    {
        [Fact]
        public void Int1ReturnsRomanI()
        {
            Assert.Equal(NumeralConverter.IntToRoman(1), "I");
        }

        [Fact]
        public void IntOverRomanRange(){
            Assert.Throws<IndexOutOfRangeException>(() => NumeralConverter.IntToRoman(4000));
        } 

        [Fact]
        public void IntUnderRomanRange(){
            Assert.Throws<IndexOutOfRangeException>(() => NumeralConverter.IntToRoman(0));
        }

        [Fact]
        public void Int2ReturnsRomanII(){
            Assert.Equal(NumeralConverter.IntToRoman(2), "II");
        }

        [Fact]
        public void Int5ReturnsRomanV(){
            Assert.Equal(NumeralConverter.IntToRoman(5), "V");
        }
    }
}

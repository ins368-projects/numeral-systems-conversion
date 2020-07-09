using System;
using Xunit;
using NumeralSystemsConversion.Converter;

namespace NumeralSystemsConversion.Tests
{
    public class NumeralConverterUnitTests
    {
        [Fact]
        public void RomanToArab_InputIII_Return3()
        {
            var arabic = NumeralConverter.RomanToArab("III");
            Assert.Equal(3, arabic);
        }

        [Fact]
        public void RomanToArab_InputV_Return5()
        {
            var arabic = NumeralConverter.RomanToArab("V");
            Assert.Equal(5, arabic);
        }

        [Fact]
        public void RomanToArab_InputIIII_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToArab("IIII");
            Assert.Equal(-1, arabic);
        }



    }
}

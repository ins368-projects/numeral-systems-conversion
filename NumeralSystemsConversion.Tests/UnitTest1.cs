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

        [Fact]
        public void RomanToArab_InputMoreThanThreeEqualNumbers_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToArab("XXXX");
            Assert.Equal(-1, arabic);
        }

        [Fact]
        public void RomanToArab_InputRepetitionOfV_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToArab("VV");
            Assert.Equal(-1, arabic);
        }

        [Fact]
        public void RomanToArab_InputRepetitionOfL_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToArab("LL");
            Assert.Equal(-1, arabic);
        }
        [Fact]
        public void RomanToArab_InputRepetitionOfD_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToArab("DDD");
            Assert.Equal(-1, arabic);
        }

        [Fact]
        public void RomanToArab_InputXXV_Return25()
        {
            var arabic = NumeralConverter.RomanToArab("XXV");
            Assert.Equal(25, arabic);
        }

        [Fact]
        public void RomanToArab_InputIX_Return9()
        {
            var arabic = NumeralConverter.RomanToArab("IX");
            Assert.Equal(9, arabic);
        }

        [Fact]
        public void RomanToArab_InputInLowerCasexxiv_Return24()
        {
            var arabic = NumeralConverter.RomanToArab("xxiv");
            Assert.Equal(24, arabic);
        }

        [Fact]
        public void RomanToArab_InputWithSpacesVII_I_Return19()
        {
            var arabic = NumeralConverter.RomanToArab("XI X");
            Assert.Equal(19, arabic);
        }

        [Fact]
        public void RomanToArab_InputIsNonValidLetter_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToArab("VAA");
            Assert.Equal(-1, arabic);
        }

        [Fact]
        public void RomanToArab_InputMMMM_ReturnNegativeOne()
        {
            var arabic = NumeralConverter.RomanToArab("MMMM");
            Assert.Equal(-1, arabic);
        }

        [Fact]
        public void RomanToArab_InputMMMCMXCIX_Return3999()
        {
            var arabic = NumeralConverter.RomanToArab("MMMCMXCIX");
            Assert.Equal(3999, arabic);
        }
    }
}

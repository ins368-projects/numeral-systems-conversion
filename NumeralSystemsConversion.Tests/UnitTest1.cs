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
            Assert.Equal("I", NumeralConverter.IntToRoman(1));
        }

        [Fact]
        public void IntOverRomanRange()
        {
            Assert.Throws<IndexOutOfRangeException>(() => NumeralConverter.IntToRoman(4000));
        }

        [Fact]
        public void IntUnderRomanRange()
        {
            Assert.Throws<IndexOutOfRangeException>(() => NumeralConverter.IntToRoman(0));
        }

        [Fact]
        public void Int2ReturnsRomanII()
        {
            Assert.Equal("II", NumeralConverter.IntToRoman(2));
        }

        [Fact]
        public void Int5ReturnsRomanV()
        {
            Assert.Equal("V", NumeralConverter.IntToRoman(5));
        }

        [Fact]
        public void Int10ReturnsRomanX()
        {
            Assert.Equal("X", NumeralConverter.IntToRoman(10));
        }

        [Fact]
        public void Int4ReturnsRomanIV()
        {
            Assert.Equal("IV", NumeralConverter.IntToRoman(4));
        }

        [Fact]
        public void Int400ReturnsRomanCD()
        {
            Assert.Equal("CD", NumeralConverter.IntToRoman(400));
        }

        [Fact]
        public void Int48ReturnsRomanXLVIII()
        {
            Assert.Equal("XLVIII", NumeralConverter.IntToRoman(48));
        }

        [Fact]
        public void Int498ReturnsRomanCDXCVIII()
        {
            Assert.Equal("CDXCVIII", NumeralConverter.IntToRoman(498));
        }

        [Fact]
        public void Int1021ReturnsRomanMXXI()
        {
            Assert.Equal("MXXI", NumeralConverter.IntToRoman(1021));
        }
        [Fact]
        public void Int2020ReturnsRomanMMXX()
        {
            Assert.Equal("MMXX", NumeralConverter.IntToRoman(2020));
        }



    }
}

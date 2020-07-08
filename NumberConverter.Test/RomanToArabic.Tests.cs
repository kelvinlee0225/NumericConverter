using NumberConverter;
using NUnit.Framework;
using System;

namespace NumberConverter.Test
{
    public class RomanToArabicTests
    {
        
        [SetUp]
        public void Setup()
        {
            
        }

        
        [Test]
        public void RomanToArabic_Returns_16_When_Given_XVI()
        {
            Assert.AreEqual(16, RomanToArabic.ConvertToArabic("XVI"));
        }

        [Test]
        public void RomanToArabic_Returns_5_When_Given_V()
        {
            Assert.AreEqual(5, RomanToArabic.ConvertToArabic("V"));
        }

        [Test]
        public void RomanToArabic_Throws_Exception_When_Given_NonRoman_Number()
        {
            Assert.Throws<ArgumentException>(() => RomanToArabic.ConvertToArabic("ASDF"));
        }

        [Test]
        public void RomanToArabic_Returns_4_When_Given_IV()
        {
            Assert.AreEqual(4, RomanToArabic.ConvertToArabic("IV"));
        }

        [Test]
        public void RomanToArabic_Returns_7_When_Given_VII()
        {
            Assert.AreEqual(7, RomanToArabic.ConvertToArabic("vii"));
        }

        [Test]
        public void RomanToArabic_Throws_Exception_When_Given_TooManyConsecutives_VIIII()
        {
            Assert.Throws<ArgumentException>(() => RomanToArabic.ConvertToArabic("VIIII"));
        }

        [Test]
        public void RomanToArabic_Throws_Exception_When_Given_InvalidConsecutives_MMLL()
        {
            Assert.Throws<ArgumentException>(() => RomanToArabic.ConvertToArabic("MMLL"));
        }

        [Test]
        public void RomanToArabic_Returns_2020_When_Given_MMXX()
        {
            Assert.AreEqual(2020, RomanToArabic.ConvertToArabic("MMXX"));
        }
    
    }
}
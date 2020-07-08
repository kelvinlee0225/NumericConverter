using NumberConverter;
using NUnit.Framework;
using System;

namespace NumberConverter.Test
{
    public class ArabicToRomanTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        
        public void ArabicToRoman_Returns_V_When_Given_5()
        {
            Assert.AreEqual("V", ArabicToRoman.ConvertToRoman(5));
        }

        [Test]
        public void ArabicToRoman_Returns_XX_When_Given_20()
        {
            Assert.AreEqual("XX", ArabicToRoman.ConvertToRoman(20));
        }

        [Test]
        public void ArabicToRoman_Returns_M_When_Given_1000()
        {
            Assert.AreEqual("M", ArabicToRoman.ConvertToRoman(1000));
        }

        [Test]
        public void ArabicToRoman_Returns_MM_When_Given_2000()
        {
            Assert.AreEqual("MM", ArabicToRoman.ConvertToRoman(2000));
        }

        [Test]
        public void ArabicToRoman_Returns_CCC_When_Given_300()
        {
            Assert.AreEqual("CCC", ArabicToRoman.ConvertToRoman(300));
        }

        [Test]
        public void ArabicToRoman_Returns_L_When_Given_50()
        {
            Assert.AreEqual("L", ArabicToRoman.ConvertToRoman(50));
        }

        [Test]
        public void ArabicToRoman_Returns_VIII_When_Given_8()
        {
            Assert.AreEqual("VIII", ArabicToRoman.ConvertToRoman(8));
        }

        [Test]
        public void ArabicToRoman_Throws_ArgumentException_When_Given_4000()
        {
            Assert.Throws<ArgumentException>(() => ArabicToRoman.ConvertToRoman(4000));
        }

        [Test]
        public void ArabicToRoman_Throws_ArgumentException_When_Given_0()
        {
            Assert.Throws<ArgumentException>(() => ArabicToRoman.ConvertToRoman(0));
        }

        [Test]
        public void ArabicToRoman_Returns_MMCDXXV_When_Given_2425()
        {
            Assert.AreEqual("MMCDXXV", ArabicToRoman.ConvertToRoman(2425));
        }

        [Test]
        public void RomanToArabic_Returns_2425_When_Given_MMCDXXV()
        {
            Assert.AreEqual(2425, RomanToArabic.ConvertToArabic("MMCDXXV"));
        }
        
    
    
    }
}
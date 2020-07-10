using System;

namespace NumberConverter
{
    /// <summary>
    ///  This class converts numbers from arabic to roman.
    /// </summary>
    public class ArabicToRoman
    {
        private static string[] Thousands = {"", "M", "MM", "MMM"};
        private static string[] Hundreds = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
        private static string[] Tens = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
        private static string[] Ones = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};

        public static string ConvertToRoman(int arabic)
        {
            if(arabic > 3999 || arabic < 1)
            {
                throw new ArgumentException("Invalid Arabic Number");
            }   

            string result = "";

            int num = arabic/1000;
            result += Thousands[num];
            arabic %= 1000;

            num = arabic/100;
            result += Hundreds[num];
            arabic %= 100;

            num = arabic/10;
            result += Tens[num];
            arabic %= 10;

            result += Ones[arabic];

            return result;

        }
    }
}

using System;
using System.Collections.Generic;

namespace NumberConverter
{
    public class RomanToArabic
    {

        private static Dictionary<char,int> romanChars = new Dictionary<char, int> {
            {'M', 1000},
            {'D', 500},
            {'C', 100},
            {'L', 50},
            {'X', 10},
            {'V', 5},
            {'I', 1},
        };

        /// <summary>
        ///     Reads a roman number, foreach character it validates if it's roman and converts it into arabic (if it's possible)
        ///     Validations: 
        ///         - If every char is roman
        ///         - (IV <- 4): If next_value is worth more than current_value
        ///         - If valid numbers are consecutive three times max.
        ///         - If invalid numbers are NOT consecutive.
        /// </summary>
        public static int Convert(string romanNumber)
        {
            romanNumber = romanNumber.ToUpper();
            int result = 0, consecutives = 1;

            for (int i = 0; i < romanNumber.Length; i++) {
                if (!romanChars.TryGetValue(romanNumber[i], out int curr_val)) {
                    throw new ArgumentException("Invalid Roman Number. Non-Roman Chars");
                }

                if (i < romanNumber.Length - 1) {
                    romanChars.TryGetValue(romanNumber[i + 1], out int next_val);

                    //Counts consecutive values
                    if (curr_val == next_val)
                        consecutives++;
                    else
                        consecutives = 1;

                    //Validates there are no more than 3 consecutive values 
                    if (consecutives > 3)
                        throw new ArgumentException("Invalid Roman Number. Too Many Consecutive Chars");
                    else if (consecutives > 1 && (curr_val == 5 || curr_val == 50 || curr_val == 500))
                        throw new ArgumentException("Invalid Roman Number. Invalid Consecutive Chars");

                    //Checks if next value is worth more than actual value (for example: IV <- 4)
                    if (next_val > curr_val) {
                        result += next_val - curr_val;
                        i++;
                    }
                    else {
                        result += curr_val;
                    }
                }
                else {
                    result += curr_val;
                }
            }
            return result;
        }
    }
}

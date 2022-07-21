using System.Text.RegularExpressions;

namespace LeetCode_13_RomanToInt
{
    public class Class1
    {
        // Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

        // Symbol       Value
        // I             1
        // V             5
        // X             10
        // L             50
        // C             100
        // D             500
        // M             1000
        // For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

        // Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

        // I can be placed before V (5) and X (10) to make 4 and 9. 
        // X can be placed before L (50) and C (100) to make 40 and 90. 
        // C can be placed before D (500) and M (1000) to make 400 and 900.
        // Given a roman numeral, convert it to an integer.
        public int RomanToInt(string s)
        {
            // Check constraints
            CheckConstraints(s);

            int convertedInt = 0;

            while (s.Length >= 1)
            {
                string nextToken = GetNextToken(s);
                convertedInt += GetIntFromRomanToken(nextToken);
                if (nextToken.Length == 2)
                {
                    s = s.Substring(2);
                }
                else
                {
                    s = s.Substring(1);
                }
            }

            return convertedInt;
        }

        private int GetIntFromRomanToken(string token)
        {
            switch (token)
            {
                case "I":
                    return 1;
                case "IV":
                    return 4;
                case "V":
                    return 5;
                case "IX":
                    return 9;
                case "X":
                    return 10;
                case "XL":
                    return 40;
                case "L":
                    return 50;
                case "XC":
                    return 90;
                case "C":
                    return 100;
                case "CD":
                    return 400;
                case "D":
                    return 500;
                case "CM":
                    return 900;
                case "M":
                    return 1000;
                default:
                    throw new Exception($"Error - unexpected {nameof(token)} received ({token}) (202207202012)");
            }
        }

        private string GetNextToken(string s)
        {
            // Usually we can just look at a Roman number one digit at a time when converting
            // it to an integer. However there are a few special cases where we must take two
            // digits together instead of just one. These are those cases:
            //
            // IV
            // IX
            // XL
            // CD
            // CM

            if (s.Length == 1)
            {
                // If there's only one character left in the input, just return it.
                return s;
            }
            else
            {
                if (((s[0] == 'I') && (s[1] == 'V'))
                    || ((s[0] == 'I') && (s[1] == 'X'))
                    || ((s[0] == 'X') && (s[1] == 'L'))
                    || ((s[0] == 'X') && (s[1] == 'C'))
                    || ((s[0] == 'C') && (s[1] == 'D'))
                    || ((s[0] == 'C') && (s[1] == 'M'))
                    )
                {
                    // If the next two characters match any of the two-character special cases,
                    // return both of those characters.
                    return s[0].ToString() + s[1].ToString();
                }
                else
                {
                    // The only other case is where we should simply return the next single character.
                    return s[0].ToString();
                }
            }
        }

        private void CheckConstraints(string s)
        {
            // Constraints:

            // 1 <= s.length <= 15
            // s contains only the characters('I', 'V', 'X', 'L', 'C', 'D', 'M').
            // It is guaranteed that s is a valid roman numeral in the range[1, 3999].

            // Check the expected length of the input string
            if ((s.Length < 1) || (s.Length > 15))
            {
                throw new ConstraintViolationException();
            }

            // Use a RegEx to make sure the given string only contains the valid Roman digits
            Regex regex = new Regex(@"^[IVXLCDM]+$");
            if (!regex.IsMatch(s))
            {
                throw new ConstraintViolationException();
            }
        }

    }

    public class ConstraintViolationException : Exception { }
}
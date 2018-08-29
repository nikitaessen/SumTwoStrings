using System;
using System.Linq;

namespace SumTwoStrings
{
    public class Calculator
    {
        public string SumTwoStrings(string num1, string num2)
        {
            if (num1 == null)
            {
                return num2;
            }

            if (num2 == null)
            {
                return num1;
            }

            if (!num1.All(char.IsDigit) || !num2.All(char.IsDigit))
            {
                throw new ArgumentException("One of arguments is non numeric value.");
            }

            var result = string.Empty;

            if (num2.Length > num1.Length)
            {
                SwapStrings(ref num1, ref num2);
            }

            var length1 = num1.Length;
            var length2 = num2.Length;

            var diff = length1 - length2;

            num1 = new string(num1.Reverse().ToArray());
            num2 = new string(num2.Reverse().ToArray());

            var carry = 0;

            for (var i = 0; i < length2; i++)
            {
                var sum = (int)char.GetNumericValue(num1[i]) + (int)char.GetNumericValue(num2[i]) + carry;
                result += sum % 10;

                carry = sum / 10;
            }

            //Add remaining 'carry' to larger number
            for (var i = length2; i < length1; i++)
            {
                var sum = (int)char.GetNumericValue(num1[i]) + carry;
                result += sum % 10;

                carry = sum / 10;
            }

            if (carry > 0)
            {
                result += carry;
            }

            return new string(result.Reverse().ToArray());
        }

        private void SwapStrings(ref string str1, ref string str2)
        {
            str1 = string.Join(string.Empty, str1, str2);

            str2 = str1.Remove(str1.Length - str2.Length, str2.Length);
            str1 = str1.Remove(0, str2.Length);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            string x = "12345678901234567890";
            string y = "23232323232323232324";

            var calc = new Calculator();
            var sum = calc.SumTwoStrings(x, y);
        }
    }
}

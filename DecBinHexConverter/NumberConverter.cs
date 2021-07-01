using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecBinHexConverter
{
    public static class NumberConverter
    {
        public static string DecimalToBinary(string decimalNum)
        {
            bool isNegative = false;
            
            if (decimalNum.StartsWith("-"))
            {
                decimalNum = decimalNum.Remove(0,1);
                isNegative = true;
            }
            
            string result = Convert.ToString(Convert.ToInt32(decimalNum, 10), 2);

            if (isNegative)
            {
                result = result.Insert(0, "-");
            }

            return result;
        }

        public static string DecimalToHexadecimal(string decimalNum)
        {
            bool isNegative = false;

            if (decimalNum.StartsWith("-"))
            {
                decimalNum = decimalNum.Remove(0, 1);
                isNegative = true;
            }

            string result = Convert.ToString(Convert.ToInt32(decimalNum, 10), 16).ToUpper();

            if (isNegative)
            {
                result = result.Insert(0, "-");
            }

            return result;
        }

        public static string BinaryToDecimal(string binaryNum)
        {
            bool isNegative = false;

            if (binaryNum.StartsWith("-"))
            {
                binaryNum = binaryNum.Remove(0, 1);
                isNegative = true;
            }

            string result = Convert.ToString(Convert.ToInt32(binaryNum, 2), 10);

            if (isNegative)
            {
                result = result.Insert(0, "-");
            }

            return result;
        }

        public static string BinaryToHexadecimal(string binaryNum)
        {
            bool isNegative = false;

            if (binaryNum.StartsWith("-"))
            {
                binaryNum = binaryNum.Remove(0, 1);
                isNegative = true;
            }

            string result = Convert.ToString(Convert.ToInt32(binaryNum, 2), 16).ToUpper();

            if (isNegative)
            {
                result = result.Insert(0, "-");
            }

            return result;
        }

        public static string HexadecimalToDecimal(string hexNum)
        {
            bool isNegative = false;

            if (hexNum.StartsWith("-"))
            {
                hexNum = hexNum.Remove(0, 1);
                isNegative = true;
            }

            string result = Convert.ToString(Convert.ToInt32(hexNum, 16), 10);

            if (isNegative)
            {
                result = result.Insert(0, "-");
            }

            return result;
        }

        public static string HexadecimalToBinary(string hexNum)
        {
            bool isNegative = false;

            if (hexNum.StartsWith("-"))
            {
                hexNum = hexNum.Remove(0, 1);
                isNegative = true;
            }

            string result = Convert.ToString(Convert.ToInt32(hexNum, 16), 2);

            if (isNegative)
            {
                result = result.Insert(0, "-");
            }

            return result;
        }
    }
}

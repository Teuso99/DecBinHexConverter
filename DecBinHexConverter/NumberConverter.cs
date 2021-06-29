using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecBinHexConverter
{
    public static class NumberConverter
    {
        public static string DecimalToBinary(int decimalNum)
        {
            string result = Convert.ToString(decimalNum, 2);
            
            return result;
        }

        public static string DecimalToHexadecimal(int decimalNum)
        {
            string result = Convert.ToString(decimalNum, 16).ToUpper();

            return result;
        }

        public static string BinaryToDecimal(string binaryNum)
        {
            string result = Convert.ToString(Convert.ToInt32(binaryNum, 2), 10);

            return result;
        }

        public static string BinaryToHexadecimal(string binaryNum)
        {
            string result = Convert.ToString(Convert.ToInt32(binaryNum, 2), 16).ToUpper();

            return result;
        }

        public static string HexadecimalToDecimal(string binaryNum)
        {
            string result = Convert.ToString(Convert.ToInt32(binaryNum, 16), 10);

            return result;
        }

        public static string HexadecimalToBinary(string binaryNum)
        {
            string result = Convert.ToString(Convert.ToInt32(binaryNum, 16), 2);

            return result;
        }
    }
}

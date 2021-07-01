using System;
using Xunit;
using DecBinHexConverter;

namespace DecBinHexConverterTests
{
    public class DecBinHexConverterTests
    {
        // Decimal -> Binary ------------------------------------------------------------------------------------------

        [Theory]
        [InlineData("0","0")]
        [InlineData("2", "10")]
        [InlineData("10", "1010")]
        [InlineData("255", "11111111")]
        public void DecimalToBinary_Input_Expected(string input, string expected)
        {
            // Arrange
            var decimalNum = input;

            // Act
            var result = NumberConverter.DecimalToBinary(decimalNum);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("-2", "-10")]
        [InlineData("-10", "-1010")]
        [InlineData("-50", "-110010")]
        [InlineData("-255", "-11111111")]
        public void DecimalToBinary_NegativeInput_BinaryWithoutComplementExpected(string input, string expected)
        {
            // Arrange
            var decimalNum = input;

            // Act
            var result = NumberConverter.DecimalToBinary(decimalNum);

            // Assert
            Assert.Equal(expected, result);
        }

        // Decimal -> Hexadecimal ------------------------------------------------------------------------------------------

        [Theory]
        [InlineData("0", "0")]
        [InlineData("10", "A")]
        [InlineData("150", "96")]
        [InlineData("255", "FF")]
        public void DecimalToHexadecimal_Input_Expected(string input, string expected)
        {
            // Arrange
            var decimalNum = input;

            // Act
            var result = NumberConverter.DecimalToHexadecimal(decimalNum);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("-10", "-A")]
        [InlineData("-50", "-32")]
        [InlineData("-150", "-96")]
        [InlineData("-255", "-FF")]
        public void DecimalToHexadecimal_NegativeInput_HexaWithoutComplementExpected(string input, string expected)
        {
            // Arrange
            var decimalNum = input;

            // Act
            var result = NumberConverter.DecimalToHexadecimal(decimalNum);

            // Assert
            Assert.Equal(expected, result);
        }
        // Binary -> Decimal ------------------------------------------------------------------------------------------

        [Theory]
        [InlineData("0", "0")]
        [InlineData("10", "2")]
        [InlineData("1010", "10")]
        [InlineData("11111111", "255")]
        public void BinaryToDecimal_Input_Expected(string input, string expected)
        {
            // Arrange
            var binaryNum = input;

            // Act
            var result = NumberConverter.BinaryToDecimal(binaryNum);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("-10", "-2")]
        [InlineData("-1010", "-10")]
        [InlineData("-110010", "-50")]
        [InlineData("-11111111", "-255")]
        public void BinaryToDecimal_NegativeInput_NegativeDecimalExpected(string input, string expected)
        {
            // Arrange
            var binaryNum = input;

            // Act
            var result = NumberConverter.BinaryToDecimal(binaryNum);

            // Assert
            Assert.Equal(expected, result);
        }

        // Binary -> Hexadecimal ------------------------------------------------------------------------------------------

        [Theory]
        [InlineData("0", "0")]
        [InlineData("10", "2")]
        [InlineData("1010", "A")]
        [InlineData("11111111", "FF")]
        public void BinaryToHexadecimal_Input_Expected(string input, string expected)
        {
            // Arrange
            var binaryNum = input;

            // Act
            var result = NumberConverter.BinaryToHexadecimal(binaryNum);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("-10", "-2")]
        [InlineData("-1010", "-A")]
        [InlineData("-110010", "-32")]
        [InlineData("-11111111", "-FF")]
        public void BinaryToHexadecimal_NegativeInput_NegativeHexaExpected(string input, string expected)
        {
            // Arrange
            var binaryNum = input;

            // Act
            var result = NumberConverter.BinaryToHexadecimal(binaryNum);

            // Assert
            Assert.Equal(expected, result);
        }

        // Hexadecimal -> Decimal ------------------------------------------------------------------------------------------

        [Theory]
        [InlineData("0", "0")]
        [InlineData("A", "10")]
        [InlineData("96", "150")]
        [InlineData("FF", "255")]
        public void HexadecimalToDecimal_Input_Expected(string input, string expected)
        {
            // Arrange
            var hexaNum = input;

            // Act
            var result = NumberConverter.HexadecimalToDecimal(hexaNum);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("-A", "-10")]
        [InlineData("-32", "-50")]
        [InlineData("-96", "-150")]
        [InlineData("-FF", "-255")]
        public void HexadecimalToDecimal_NegativeInput_NegativeDecimalExpected(string input, string expected)
        {
            // Arrange
            var hexaNum = input;

            // Act
            var result = NumberConverter.HexadecimalToDecimal(hexaNum);

            // Assert
            Assert.Equal(expected, result);
        }

        // Hexadecimal -> Binary ------------------------------------------------------------------------------------------

        [Theory]
        [InlineData("0", "0")]
        [InlineData("2", "10")]
        [InlineData("A", "1010")]
        [InlineData("FF", "11111111")]
        public void HexadecimalToBinary_Input_Expected(string input, string expected)
        {
            // Arrange
            var hexaNum = input;

            // Act
            var result = NumberConverter.HexadecimalToBinary(hexaNum);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("-2", "-10")]
        [InlineData("-A", "-1010")]
        [InlineData("-32", "-110010")]
        [InlineData("-FF", "-11111111")]
        public void HexadecimalToBinary_NegativeInput_BinaryWithoutComplementExpected(string input, string expected)
        {
            // Arrange
            var hexaNum = input;

            // Act
            var result = NumberConverter.HexadecimalToBinary(hexaNum);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

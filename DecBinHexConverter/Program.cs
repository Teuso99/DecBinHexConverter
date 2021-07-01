using System;
using System.Threading;

namespace DecBinHexConverter
{
    class Program
    {
        private static bool Menu()
        {
            string input = String.Empty;

            Console.WriteLine("--- Decimal/Binary/Hexa Converter ---");
            Console.WriteLine("1) Decimal     ---> Binary");
            Console.WriteLine("2) Decimal     ---> Hexadecimal");
            Console.WriteLine("3) Binary      ---> Decimal");
            Console.WriteLine("4) Binary      ---> Hexadecimal");
            Console.WriteLine("5) Hexadecimal ---> Decimal");
            Console.WriteLine("6) Hexadecimal ---> Binary");
            Console.WriteLine("7) Exit");

            Console.WriteLine();

            Console.Write("> ");
            var option = Console.ReadLine();
            
            Console.WriteLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Enter a decimal number: ");
                    Console.Write("> ");
                    input = Console.ReadLine();

                    Console.WriteLine(NumberConverter.DecimalToBinary(input));
                    Console.WriteLine();
                    
                    return true;

                case "2":
                    Console.WriteLine("Enter a decimal number: ");
                    Console.Write("> ");
                    input = Console.ReadLine();

                    Console.WriteLine(NumberConverter.DecimalToHexadecimal(input));
                    Console.WriteLine();

                    return true;

                case "3":
                    Console.WriteLine("Enter a binary number: ");
                    Console.Write("> ");
                    input = Console.ReadLine();

                    Console.WriteLine(NumberConverter.BinaryToDecimal(input));
                    Console.WriteLine();

                    return true;

                case "4":
                    Console.WriteLine("Enter a binary number: ");
                    Console.Write("> ");
                    input = Console.ReadLine();

                    Console.WriteLine(NumberConverter.BinaryToHexadecimal(input));
                    Console.WriteLine();

                    return true;

                case "5":
                    Console.WriteLine("Enter a hexadecimal number: ");
                    Console.Write("> ");
                    input = Console.ReadLine();

                    Console.WriteLine(NumberConverter.HexadecimalToDecimal(input));
                    Console.WriteLine();

                    return true;

                case "6":
                    Console.WriteLine("Enter a hexadecimal number: ");
                    Console.Write("> ");
                    input = Console.ReadLine();

                    Console.WriteLine(NumberConverter.HexadecimalToBinary(input));
                    Console.WriteLine();

                    return true;

                case "7":
                    Console.WriteLine("Terminating the application!");
                    return false;

                default:
                    Console.WriteLine("Unexpected option. Please try again!");
                    Console.WriteLine();

                    return true;
            }
        }
        
        static void Main(string[] args)
        {
            bool showMenu = true;
            
            while (showMenu)
            {
                showMenu = Menu();
                
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}

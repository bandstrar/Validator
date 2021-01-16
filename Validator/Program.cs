using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a PIN code between 4 and 8 digits inclusive");
            string pinCode = Console.ReadLine();
            bool onlyDigits = true;

            while (true)
            {
                foreach (var digit in pinCode)
                    if (Char.IsDigit(digit))
                    {
                        onlyDigits = true;
                    }
                    else
                    {
                        onlyDigits = false;
                        break;
                    }
                break;
            }
            bool validPin = pinCode.Length >= 4 && pinCode.Length <= 8 && onlyDigits == true;


            Console.WriteLine(validPin);
        }
    }
}

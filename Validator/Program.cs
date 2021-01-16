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

            if (validPin == true)
            {
                Console.WriteLine("Your PIN number is valid");
            }
            else
            {
                Console.WriteLine("Your PIN number is invalid");
            }
            

            Console.WriteLine("Please enter a valid phone number");
            string userPhone = Console.ReadLine();
            string onlyPhoneDigits = userPhone.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "");
            
            bool phoneDigits = true;

            while (true)
            {
                foreach (var digit in onlyPhoneDigits)
                if (Char.IsDigit(digit))
                    {
                        phoneDigits = true;
                    }
                else
                    {
                        phoneDigits = false;
                        break;
                    }
                break;
            }
            bool validPhone = onlyPhoneDigits.Length == 10 && phoneDigits == true;

            if (validPhone == true)
            {
                Console.WriteLine("Your phone number is valid");
            }
            else
            {
                Console.WriteLine("Your phone number is invalid");
            }

            Console.WriteLine("Please enter a valid e-mail address");
            string userEmail = Console.ReadLine();

            bool containsAt = userEmail.Contains("@");
            bool containsPeriod = userEmail.Contains(".");
            bool atBeforePeriod = false;
            bool username = false;
            bool domain = false;
            bool topDomain = false;

            if (containsAt == true && containsPeriod == true)
            {
                int atIndex = userEmail.IndexOf("@");
                int periodIndex = userEmail.LastIndexOf(".");
                if (atIndex < periodIndex)
                {
                    atBeforePeriod = true;
                }
            }

            if (atBeforePeriod == true)
            {
                bool notAt = !userEmail.StartsWith("@");

                if (notAt == true)
                {
                    username = true;
                }

            }

            if (username == true)
            {
                int atIndex = userEmail.IndexOf("@");
                string validDomain = userEmail.Substring(atIndex + 1, 1);

                if (validDomain != ".")
                {
                    domain = true;
                }
            }

            if (domain == true)
            {
                int periodIndex = userEmail.LastIndexOf(".");
                string validTopDomain = userEmail.Substring(periodIndex);

                if (validTopDomain != ".")
                {
                    topDomain = true;
                }
            }

            if (topDomain == true)
            {
                Console.WriteLine("Your email address is valid");
            }
            else
            {
                Console.WriteLine("Your email address is invalid");
            }
        }
    }
}

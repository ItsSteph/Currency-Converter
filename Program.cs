using System;

namespace CurrencyConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] CurrencyNames = { "USD", "EUR", "DKK" };
            double[] CurrencyValues = {0.1, 0.09, 0.7};


            Console.WriteLine("**Currency Converter**");


            //program runs until stopped by the user
            while (true)
            {

                Console.WriteLine("1. Convert Currency");
                Console.WriteLine("2. Exit");

                string Input = Console.ReadLine();
                Console.Clear();
                if (Input == "1")
                {
                    //convert to currency
                    Console.WriteLine("Choose a currency to convert to");

                    for (int i = 1; i <= CurrencyNames.Length; i++)
                    {
                        Console.WriteLine(i + ". " + CurrencyNames[i-1]);
                    }
                    

                    Input = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Please enter amount");
                    string Amount = Console.ReadLine();
                    double Result = 0;
                    Console.Clear();

                    if (Input == "1")
                    {

                        Result = CurrencyValues[0] * Convert.ToDouble(Amount);
                        Console.WriteLine("Result: " + Result + CurrencyNames[0]);
                        

                    }
                    else if (Input == "2")
                    {

                        Result = CurrencyValues[1] * Convert.ToDouble(Amount);
                        Console.WriteLine("Result: " + Result + CurrencyNames[1]);
                        

                    }
                    else if (Input == "3")
                    {
                        Result = CurrencyValues[2] * Convert.ToDouble(Amount);
                        Console.WriteLine("Result: " + Result + CurrencyNames[2]);
                        

                    }

                }
                else if (Input == "2")
                {
                    Environment.Exit(0);
                }

            }
        }
    }
}

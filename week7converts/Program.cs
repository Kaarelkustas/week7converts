using System;

namespace week7converts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter c for farenheit to celcius to fahreneit");
            string userInput = Console.ReadLine();
            if(userInput == "c")
            {
                ToCelcius();
            }else
            {
                ToFarenheit();
            }

        }
        public static void ToCelcius()
        {
            Console.WriteLine("Enter the tempature in f:");
                int tempF = Int32.Parse(Console.ReadLine());
            double result = (tempF - 32) * 5 / 9;
            Console.WriteLine($"Result in Celcius: {result} ");
        }
        public static void ToFarenheit()
        {
            Console.WriteLine("Enter the tempature in c:");
                int tempC = Int32.Parse(Console.ReadLine());
            double result = (tempC * 9) / 5 + 32;
            Console.WriteLine($"Result in farenheit: {result}");
        }

    }
}

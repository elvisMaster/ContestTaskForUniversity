using System;

namespace convertCelsius2KelvinFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} {1}", celsius + 273, celsius * 18 / 10 + 32);

        }
    }
}

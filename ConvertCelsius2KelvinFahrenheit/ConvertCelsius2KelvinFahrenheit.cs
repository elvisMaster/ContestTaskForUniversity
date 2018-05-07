using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

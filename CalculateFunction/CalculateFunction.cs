using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            double y = int.MaxValue;

            if (x > 0)
                y = 2 * x - 10;
            else if (x == 0)
                y = 0;
            else if (x < 0)
                y = 2 * Math.Abs(x) - 1;

            Console.WriteLine(y);
        }
    }
}

using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            double a = input[0];
            double b = input[1];

            Console.WriteLine("{0} {1}", a * b, (a + b) * 2);
        }
    }
}

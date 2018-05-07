using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToDouble(arrTemp));

            double index = 0;
            double min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                var tmp = Math.Abs(arr[i]);
                if (tmp < min)
                {
                    index = i;
                    min = tmp;
                }
            }

            Console.WriteLine(min);
        }
    }
}

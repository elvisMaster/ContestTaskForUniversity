using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
                if (Math.Abs(arr[i]) > 50)
                    count++;

            Console.WriteLine(count);
        }
    }
}

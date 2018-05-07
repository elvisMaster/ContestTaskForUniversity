using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int mult = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    if (mult == 0)
                        mult = arr[i];
                    else
                        mult *= arr[i];
                }
            }

            Console.WriteLine(mult);
        }
    }
}

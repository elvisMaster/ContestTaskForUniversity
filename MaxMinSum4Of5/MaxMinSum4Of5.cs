using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Array.Sort(arr);
            Int64 op1 = 0, op2 = 0;
            for (int i = 0; i < 4; i++)
            {
                op1 += arr[i];
                op2 += arr[4 - i];
            }
            Console.WriteLine(op1 + " " + op2);
        }
    }
}

using System;

namespace calculateFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f = 1, num;
            
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;

            Console.WriteLine("{0}", f);
            Console.Read();
        }
    }
}
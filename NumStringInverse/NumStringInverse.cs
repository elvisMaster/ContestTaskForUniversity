using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string result = "";
            for (int i = 0; i < number.Length; i++)
            {
                result += number[number.Length - 1 - i];
            }

            Console.WriteLine(result);
        }
    }
}

using System;

namespace findCoOrdinate
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] data = Console.ReadLine().Split(' ');
            int co1 = int.Parse(data[0]);
            int co2 = int.Parse(data[1]);

            if (co1 > 0 && co2 > 0)
                Console.Write("1");
            else if (co1 < 0 && co2 > 0)
                Console.Write("2");
            else if (co1 < 0 && co2 < 0)
                Console.Write("3");
            else if (co1 > 0 && co2 < 0)
                Console.Write("4");
            else if (co1 == 0 && co2 == 0)
                Console.Write("origin", co1, co2);
            else if (co1 == 0 && co2 != 0)
                Console.Write("Y");
            else if (co1 != 0 && co2 == 0)
                Console.Write("X");
            Console.ReadLine();
        }
    }
}
using System;

namespace sravnenie_chisel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            if (a > b) Console.WriteLine(a.ToString()+">"+b.ToString());
            if (a < b) Console.WriteLine(a.ToString() + "<" + b.ToString());
            if (a == b) Console.WriteLine(a.ToString() + "=" + b.ToString());
        }
    }
}

using System;

namespace Шахматы_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            if ((a - c) * (a - c) + (b - d) * (b - d) <= 2)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}

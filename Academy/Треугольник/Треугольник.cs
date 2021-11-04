using System;

namespace Треугольник
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if ((a == b) && (b == c))
                Console.WriteLine(3);
            else if ((a == b) || (b == c) || (c == a))
                Console.WriteLine(2);
            else
                Console.WriteLine(0);

        }
    }
}

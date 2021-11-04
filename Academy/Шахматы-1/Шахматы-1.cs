using System;

namespace Шахматы_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, x, y;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if ((n == x) || (m == y))
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write("NO");
            }
        }
    }
}

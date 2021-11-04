using System;

namespace Бассейн
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

            if (n != Math.Min(n, m))
            {
                n += m;
                m = n - m;
                n = n - m;
            }

            if (x != Math.Min(n - x, x))
                x = n - x;

            if (y != Math.Min(m - y, y))
                y = m - y;

            int result=Math.Min(x, y);
            Console.WriteLine(result);
        }
    }
}

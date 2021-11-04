using System;

namespace Улитка
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            int.TryParse(Console.ReadLine(), out h);
            int a;
            int.TryParse(Console.ReadLine(), out a);
            int b;
            int.TryParse(Console.ReadLine(), out b);
            h -= a;
            if (h % (a - b) == 0)
                Console.WriteLine(h / (a - b) + 1);
            else
                Console.WriteLine(h / (a - b) + 2);
        }
    }
}

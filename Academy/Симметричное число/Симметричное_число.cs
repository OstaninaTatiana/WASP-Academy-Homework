using System;

namespace Симметричное_число
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int k;
            if (n >= 10000)
                k = 4;
            else if (n >= 1000)
                k = 3;
            else if (n >= 100)
                k = 2;
            else if (n >= 10)
                k = 1;
            else
                k = 0;
            double res = 0;
            for (int i = k; i >= 0; i--)
            {
                res += (n % 10) * Math.Pow(10, i);
                n /= 10;
            }
            Console.WriteLine(res);
        }
    }
}

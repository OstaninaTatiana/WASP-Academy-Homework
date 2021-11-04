using System;
using System.Collections.Generic;

namespace _123
{
    class Program
    {
        public static void F1(int[])
        {
            if (n > 1)
                return n * Factorial(n - 1);
            else
                return 1;
        }

        static void Main(string[] args)
        {
            int n;
            string a;
            a = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out n);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            Console.WriteLine(Factorial(n));
        }
    }
}

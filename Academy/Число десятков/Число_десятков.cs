using System;

namespace Число_десятков
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            
            Console.WriteLine(n % 100 / 10);
        }
    }
}

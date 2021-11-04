using System;

namespace Последняя_цифра
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine(n % 10);
        }
    }
}

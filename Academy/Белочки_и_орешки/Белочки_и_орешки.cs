using System;

namespace Белочки_и_орешки
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out k);
            Console.WriteLine(k / n);
        }
    }
}

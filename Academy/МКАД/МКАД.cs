using System;

namespace МКАД
{
    class Program
    {
        static void Main(string[] args)
        {
            int v, t;
            v = int.Parse(Console.ReadLine());
            t = int.Parse(Console.ReadLine());
            bool f=true;
            if (v < 0)
            {
                f = false;
                v = -v;
            }
            if (f)
                Console.WriteLine(v * t % 109);
            else
                Console.WriteLine((109 - (v * t % 109)) % 109);
        }
    }
}

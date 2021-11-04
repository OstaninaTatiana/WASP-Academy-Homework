using System;
using System.Collections.Generic;

namespace Homework5
{
    class Homework5
    {
        static int[] m1_in()
        {
            Console.WriteLine("Введите длину массива");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[] m = new int[n];
            string[] s = new string[n];
            s = Console.ReadLine().Split(" ");
            for (int i = 0; i < n; i++)
            {
                int.TryParse(s[i], out m[i]);
            }
            return m;
        }

        static void n1()
        {
            int[] m = m1_in();
            foreach (int i in m)
            {
                if (Array.IndexOf(m, i) == Array.LastIndexOf(m, i))
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
        }

        static void n2()
        {
            int[] m = m1_in();
            int a;
            for (int i = 1; i < m.Length; i++)
            {
                for (int j = 0; j < m.Length - i; j++)
                {
                    if (m[j] > m[j+1])
                    {
                        a = m[j];
                        m[j] = m[j + 1];
                        m[j + 1] = a;
                    }
                }
            }
            Console.WriteLine($"{string.Join(" ", m)}");
        }

        static void n3()
        {
            int.TryParse(Console.ReadLine(), out int m);
            int.TryParse(Console.ReadLine(), out int n);
            int k = 0;
            double p = Math.Pow(m, k);
            while (p < n)
            {
                k += 1;
                p = Math.Pow(m, k);
            }
            if (p == n)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

        static void n4()
        {
            List<int> a = new List<int>();
            int.TryParse(Console.ReadLine(), out int n);
            while (n != 0)
            {
                a.Add(n);
                int.TryParse(Console.ReadLine(), out n);
            }
            n = a.Count;
            double s = 0;
            foreach (int i in a)
            {
                s += i;
            }
            s /= n;
            double res=0;
            foreach (int i in a)
            {
                res += (i - s) * (i - s);
            }
            res = Math.Sqrt(res / (n - 1));
            Console.WriteLine(res);
        }

        static void n5()
        {
            string[] buf;
            buf = Console.ReadLine().Split();
            int.TryParse(buf[0], out int n);
            int.TryParse(buf[1], out int k);
            string[] a = new string[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = "I";
            }
            for (int i=0; i < k; i++)
            {
                buf = Console.ReadLine().Split(" ");
                int.TryParse(buf[0], out int l);
                int.TryParse(buf[1], out int r);
                for (int j=l-1; j < r; j++)
                {
                    a[j] = ".";
                }
            }
            Console.WriteLine($"{string.Join("", a)}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            n1();
            Console.WriteLine("Задача 2");
            n2();
            Console.WriteLine("Задача 3");
            n3();
            Console.WriteLine("Задача 4");
            n4();
            Console.WriteLine("Задача 5");
            n5();
        }
    }
}

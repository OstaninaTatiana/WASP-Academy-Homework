using System;
using System.IO;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static int[] m1_in()
        {
            Console.WriteLine("Введите длину массива");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[] m = new int[n];
            string[] s = new string[n];
            s = Console.ReadLine().Split(" ");
            for (int i=0; i<n; i++)
            {
                int.TryParse(s[i], out m[i]);
            }
            return m;
        }

        static int[][] m2_in()
        {
            Console.WriteLine("Введите длину массива");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[][] m = new int[n][];
            for (int i=0; i<n; i++)
            {
                m[i] = m1_in();
            }
            return m;
        }

        static int[][][] m3_in()
        {
            Console.WriteLine("Введите длину массива");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[][][] m = new int[n][][];
            for (int i = 0; i < n; i++)
            {
                m[i] = m2_in();
            }
            return m;
        }

        static void m1_out(int[] m)
        {
            Console.WriteLine($"{string.Join(", ", m)}");
        }

        static void m2_out(int[][] m)
        {
            foreach (int[] i in m)
                m1_out(i);
        }

        static void m3_out(int[][][] m)
        {
            foreach (int[][] i in m)
            {
                m2_out(i);
                Console.WriteLine("-----------------");
            }
        }

        static void n1()
        {
            Console.WriteLine("Введите степень вложенности массива чисел");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            if (n == 1)
                m1_out(m1_in());
            if (n == 2)
                m2_out(m2_in());
            if (n == 3)
                m3_out(m3_in());
        }



        static void n2()
        {
            Console.WriteLine("Введите степень вложенности массива чисел");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            if (n == 1)
            {
                int max = -2147483648;
                int min = 2147483647;
                int count_max = 0;
                int count_min = 0;
                foreach (int a in m1_in())
                {
                    if (a == max)
                    {
                        count_max++;
                    }
                    if (a > max)
                    {
                        max = a;
                        count_max = 1;
                    }
                    if (a == min)
                    {
                        count_min++;
                    }
                    if (a < min)
                    {
                        min = a;
                        count_min = 1;
                    }
                    
                    
                }
                Console.Write("Минимальное число: ");
                Console.WriteLine(min);
                Console.Write("Встречается раз: ");
                Console.WriteLine(count_min);
                Console.Write("Максимальное число: ");
                Console.WriteLine(max);
                Console.Write("Встречается раз: ");
                Console.WriteLine(count_max);
            }
            if (n == 2)
            {

                int[][] m = m2_in();
                int max = -2147483648;
                int min = 2147483647;
                int count_max = 0;
                int count_min = 0;
                foreach (int[] b in m)
                {
                    foreach (int a in b)
                    {
                        if (a > max)
                        {
                            max = a;
                            count_max = 1;
                        }
                        else if (a == max)
                        {
                            count_max++;
                        }
                        if (a < min)
                        {
                            min = a;
                            count_min = 1;
                        }
                        else if (a == min)
                        {
                            count_min++;
                        }

                    }
                }
                Console.Write("Минимальное число: ");
                Console.WriteLine(min);
                Console.Write("Встречается раз: ");
                Console.WriteLine(count_min);
                Console.Write("Максимальное число: ");
                Console.WriteLine(max);
                Console.Write("Встречается раз: ");
                Console.WriteLine(count_max);
            }
        }

        static void n3()
        {
            Console.WriteLine("Введите степень вложенности 1 массива чисел");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            if (n == 1)
            {
                int[] m1 = m1_in();
            }
            if (n == 2)
            {
                int[][] m1 = m2_in();
            }
            Console.WriteLine("Введите степень вложенности 2 массива чисел");
            int.TryParse(Console.ReadLine(), out n);
            if (n == 1)
            {
                int[] m2 = m1_in();
            }
            if (n == 2)
            {
                int[][] m2 = m2_in();
            }
            
        }

        static void n4()
        {
            Console.WriteLine("Введите степень вложенности 1 массива чисел");
            int n1;
            int.TryParse(Console.ReadLine(), out n1);
            Console.WriteLine("Введите степень вложенности 2 массива чисел");
            int n2;
            int.TryParse(Console.ReadLine(), out n2);
            if ((n1 == 1) && (n2 == 1))
            {
                int[] m1 = m1_in();
                int[] m2 = m1_in();
                Console.WriteLine($"{string.Join(", ", new int[] {1, Math.Min(m1.GetLength(0), m2.GetLength(0))})}");
            }
            if ((n1 == 1) && (n2 == 2))
            {
                int[] m1 = m1_in();
                int[][] m2 = m2_in();
                Console.WriteLine($"{string.Join(", ", new int[] {1, Math.Min(m1.GetLength(0), m2[0].GetLength(0))})}");
            }
            if ((n1 == 2) && (n2 == 1))
            {
                int[][] m1 = m2_in();
                int[] m2 = m1_in();
                Console.WriteLine($"{string.Join(", ", new int[] {1, Math.Min(m2.GetLength(0), m1[0].GetLength(0))})}");
            }
            if ((n1 == 2) && (n2 == 2))
            {
                int[][] m1 = m2_in();
                int[][] m2 = m2_in();
                Console.WriteLine($"{string.Join(", ", new int[] {Math.Min(m1.GetLength(0), m2.GetLength(0)), Math.Min(m2[0].GetLength(0), m1[0].GetLength(0))})}");
            }
        }

        static void n5()
        {
            int[] m1 = m1_in();
            int[] m2 = m1_in();
            int l = m1.GetLength(0);
            int[] k = new int[l];
            for (int i=0; i<l; i++)
            {
                k[i] = m1[i] + m2[i];
            }
            m1_out(k);
        }

        static void n6()
        {
            int[] m1 = m1_in();
            int[] m2 = m1_in();
            int l = m1.GetLength(0);
            int k = 0;
            for (int i = 0; i < l; i++)
            {
                if (m1[i] == m2[i])
                    k++;
            }
            Console.WriteLine(k * 100 / l);
        }

        static void n7()
        {
            int[] m1 = m1_in();
            int[] m2 = m1_in();
            int l = m1.GetLength(0);
            int k = 0;
            for (int i = 0; i < l; i++)
            {
                k += m1[i] + m2[i];
            }
            Console.WriteLine(k / l / 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            n1();
/*Тесты к 1 заданию (чтобы не вводить ручками)
* Тест 1
1
5
9 5 7 4 2
* Тест 2
2
3
4
5 9 8 3
4
7 5 3 66
4
9 6 7 23
* Тест 3
3
2
4
5
4 8 5 6 7
5
2 6 8 4 6
5
9 4 5 7 2
5
5 74 23 6 45
2
3
67 423 524
3
543 432 543
*/
            Console.WriteLine("Задача 2");
            n2();
// Для теста можно использовать тесты 1 и 2 задачи 1
            Console.WriteLine("Задача 3");
            n3();
// Также можно использовать тесты 1 и 2
            Console.WriteLine("Задача 4");
            n4();
            Console.WriteLine("Задача 5");
            n5();
            Console.WriteLine("Задача 6");
            n6();
            Console.WriteLine("Задача 7");
            n7();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class session05
    {

        static void Main(string[] args)
        {
            //baitap01();
            //baitap01b();
            //baitap02();
            baitap03();

        }
        static void baitap01()
        {
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            int c = Convert.ToInt16(Console.ReadLine());
            int m = max(a, b, c);
            Console.WriteLine(m);


            static int max(int a, int b, int c)
            {

                return Math.Max(Math.Max(a, b), c);
            }
            Console.ReadKey();
        }
        static void baitap01b()
        {
            int M = Max(1, 2, 3, 4, 5, 6, 7);
            Console.WriteLine(M);
            static int Max(int a, params int[] args)
            {
                int m = args[0];
                foreach (int i in args)
                {
                    if (i > m)
                    {
                        m = i;
                    }

                }
                return Math.Max(a, m);
            }
        }
        static void baitap02()
        {
            int n = Convert.ToInt16(Console.ReadLine());
            long f = factorial(n);
            Console.WriteLine(f);
            static long factorial (int n)
            {
                long f = 1;
                for (int i = 1; i <= n; i++)
                    f *= i;
                return f;
            }
            static long factorial_recursion (int n)
            {
                if (n == 0) return 1;
                return n * factorial_recursion (n-1);
            }
            
        }
        static void baitap03()
        {
            int n = Convert.ToInt16(Console.ReadLine());
            bool ch = check(n);
            Console.WriteLine(ch);
            static bool check(int n)
            {
                int a = 0;

                for (int i = 2; i <= n/2; i++)
                {
                    if (n% i == 0)
                    {
                        a++;
                    }
                }
                if (a == 0 && n != 1) return true;
                else return false;
            }

        }
        static void baitap06()

        {
            int n = Convert.ToInt16(Console.ReadLine());

            static void printPrimenumberundernumberN(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (isPrime(i)) Console.WriteLine(i);
                }
            }
            
            static void printFirstPrimenumber (int n)
            {
                int count = 0;
                int number = 1;
                while (count <= n)
                {
                    if (isPrime(number))
                    {
                        Console.WriteLine(count);
                        count++;
                    }
                    number++;

                }
            }
        }
    }
}


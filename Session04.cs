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
            //baitap03();
            //baitap04();            
            //baitap05();
            baitap06();

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
        static void baitap04()

        {
            int n = Convert.ToInt16(Console.ReadLine());
            printFirstNprimeNumber(n);
            printPrimeNumberUnderN(n);
            static bool isPrime(int number)            
            {
                for (int i = 2; i <= number / 2; i++)
                    if (number % i == 0)
                        return false;
                return true;
            }
            static void printPrimeNumberUnderN(int n)
            {
                for(int i = 1;i<=n;i++)
                    if(isPrime(i))
                        Console.WriteLine(i);
            }

            static void printFirstNprimeNumber(int n)
            {
                int count = 0;
                int number = 1;
                while (count <= n)
                {
                    if (isPrime(number))
                    {
                        Console.WriteLine($"{count}: {number}");
                        count++;
                    }
                    number++;
                }
            }
        }
        static void baitap05()
        {
            int n = Convert.ToInt16(Console.ReadLine());
            bool p1 = isPerfectnumber(n);
            Console.WriteLine($"n = {n} is a perfect number: {p1}");
            printPerfectNumberUnder1000(n);
            static bool isPerfectnumber(int n)
            { 
                int a = 0;
                for (int i = 1; i <= n / 2; i++)
                {
                    if (n % i == 0) a = a + i;
                }
                if (a == n) return true;
                else return false; 
            }
            static void printPerfectNumberUnder1000(int n) 
            {
               for (int i = 1; i < 1000; i++)
                {
                    if (p1(i) == true) Console.WriteLine(i);
                }
            }
        }
        static void baitap06()
        {
            string s = Console.ReadLine();
            s = s.ToLower();
            bool check = checkPangram(s);
            Console.WriteLine($"The string '{s}' is a pangram: {check}");
            static bool checkPangram(string s)
            {
                bool [] check = new bool [26];
                foreach (char c in s)
                {
                    for (char a = 'a'; a <= 'z'; a++)
                    {
                        if (c == a) check[c - 'a'] = true;
                    }
                }
                foreach (bool b in check)
                {
                    if (b==false) return false;
                    else return true;
                }
            }
        }
    }
}

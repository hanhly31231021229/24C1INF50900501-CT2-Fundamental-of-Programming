using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session07
{
    internal class baitap
    {
        
        static void baitap01()
        {
            int[][] jaggedArray =
            {
                new int [] {1,1,1,1,1,1 }
                , new int [] {2,2 }
                , new int [] {3,3,3,3}
                , new int [] {4,4 }
            };
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row" + i + ": ");
                for(int j = 0;j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }    
        }
        static void baitap02()
        {
            static void init_random(int[][] a, int rows)
            {
                Random rnd = new Random();
                for (int i = 0;i < rows; i++)
                {
                    Console.WriteLine($"Enter the No columns of the rows {i}th: ");
                    int cols = int.Parse(Console.ReadLine());
                    a[i] = new int[cols];
                    for (int j = 0; j < cols; j++)
                        a[i][j] = rnd.Next(10, 50);
                }
            }
           static void intit_from_user(int[][] a)
            {
                Console.WriteLine("Moi nguoi dung nhap so dong: ");
                int rowuser = int.Parse(Console.ReadLine());

            }
            static void print(int[][] a)
            {
                for (int i =0; i<a.Length; i++)
                {
                    for (int j =0; j < a[i].Length;j++)
                        Console.WriteLine(a[i][j]+"\t");
                    Console.WriteLine();
                }
            }
            static int max(int[][] a)
            {
                int[] max = new int[a.Length];
                for (int i = 0; i > a.Length; i++)
                {
                    int e = a[i][0];
                    for(int j = 1;j < a[i].Length;j++)
                    {
                        if (e < a[i][j])
                        {
                            e = a[i][j];
                            max[j] = e;
                        }
                    } 
                    Console.WriteLine($"Max number of row {i}: {e}");
                }
                int f;
                for (int i = 0; i < max.Length; i++)
                {
                     f = max[0];
                    if (f < max[i]) f = max[i];
                }
                Console.WriteLine($"Max number of array is : {f}");   
                return 0;
            }
            static void sort_array(int[] a)
            {
                for(int i = 0; i<a.Length; i++)
                    for(int j = 0; j<a.Length; j++)
                    if (a[i] < a[j])
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }    
            }
            static void sort_rows(int[][] a)
            {
                for(int i = 0; i<a.Length; i++) sort_array(a[i]);
            }
            static bool isPrime(int num)
            {
                for (int i=2; i<num; i++)
                {
                    if (num % i ==0) return false;
                }
                return true;
            }
            static void print_primes(int[][] a)
            {
                for (int i = 0; i<a.Length; i++)
                {
                    for(int j = 0; j < a[i].Length; j++)
                        if (isPrime(a[i][j])) Console.WriteLine($"{a[i][j]} appears at row [{i}], col [{j}]");
                }    
            }
            static void search_and_print(int[][] a, int val)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++)
                        if (a[i][j] == val) Console.WriteLine($"{val} appears at row [{i}], col [{j}]");    
                }
            }
            static int menu()
            {
                Console.WriteLine("\t\tjagged array demo\n");
                Console.WriteLine("1. Jagged array init");
                Console.WriteLine("2. print array");
                Console.WriteLine("3. Print the biggest number of each row and the largest number of the whole array ");
                Console.WriteLine("4. Sort values ascending of each row");
                Console.WriteLine("5. Print items of the array that are prime.");
                Console.WriteLine("6. Search and print all positions of a number (enter from the user) ");
                Console.WriteLine("0. exit");
                Console.WriteLine();
                Console.Write("Your select <1..6>");
                int sel = 0;
                while(true)
                {
                    bool c = int.TryParse(Console.ReadLine(), out sel);
                    if (c && sel >= 0 && sel <= 6)
                        break;
                    else Console.WriteLine("Please enter a valid choice!");
                }
                return sel;
            }
            static void Main(string[] args)
            {
                //baitap01();
                Console.Write("Enter the No rows: ");
                int rows = int.Parse(Console.ReadLine());
                int[][] a = new int[rows][];
                while (true)
                {
                    int sel = menu();
                    switch (sel)
                    {
                        case 0: Console.WriteLine("Bye");return;
                            case 1: init_random(a,rows); break;
                            case 2: print(a);break;
                            case 3: max(a);break;
                            case 4: sort_rows(a); break;
                            case 5: print_primes(a); break;

                    }
                }    
            }
        }
    }
}

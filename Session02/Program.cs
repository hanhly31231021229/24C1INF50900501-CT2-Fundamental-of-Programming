// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;
namespace Session02
{
    internal class Baitap
    {
        public static void Main(string[] args)
        {
            baitap01();
            //baitap02();
            //baitap03();
            //baitap04();
            //baitap05();
            //baitap06();
            //baitap07();
            //baitap08();
            //baitap09();
            //baitap10();
        }
        static void baitap01()
        {
            Console.WriteLine("Nhap so thu nhat: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {sum}");
        }
        static void baitap02()
        {
            Console.WriteLine("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Truoc khi doi, a = {a}, b = {b} ");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Sau khi doi, a = {a}, b = {b}");
        }
        static void baitap03()
        {
            Console.WriteLine("Nhap so thu nhat: ");
            float number1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            float number2 = Convert.ToSingle(Console.ReadLine());
            float multiply = number1 * number2;
            Console.WriteLine($"{number1} * {number2} = {multiply}");
        }
        static void baitap04()
        {
            Console.WriteLine("Nhap do dai co don vi feet: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = a / 3.2808;
            Console.WriteLine($"{a} feet = {b} meter");
        }
        static void baitap05()
        {
            Console.WriteLine("Nhap nhiet do co don vi do C: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = (9 / 5) * a + 32;
            Console.WriteLine($"Vay {a} do C = {b} do F");
            Console.ReadLine();
            Console.WriteLine("Nhap nhiet do co don vi do F: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = (5 / 9) * (c - 32);
            Console.WriteLine($"Vay {c} do F = {d} do C");
        }
        static void baitap06()
        {
            Console.WriteLine($"Size of int: {sizeof(int)} ");
            Console.WriteLine($"Size of float: {sizeof(float)} ");
            Console.WriteLine($"Size of char: {sizeof(char)} ");
            Console.WriteLine($"Size of double: {sizeof(double)} ");
            Console.WriteLine($"Size of bool: {sizeof(bool)} ");

        }
        static void baitap07()
        {

        }
        static void baitap08()
        {
            Console.WriteLine("Nhap ban kinh cua hinh tron: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double s = r * r * 3.14;
            Console.WriteLine($"Dien tich hinh tron la: {s}");
        }
        static void baitap09()
        {
            Console.WriteLine("Nhap do dai canh hinh vuong: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double s = a * a;
            Console.WriteLine($"Dien tich hinh vuong la: {s}");
        }
        static void baitap10()
        {
            Console.WriteLine("Nhap so ngay: ");
            int day = Convert.ToInt32(Console.ReadLine());
            int year = day / 365;
            int week = (day % 365) / 7;
            int days = (day % 365) % 7;
            Console.WriteLine($"Vay {day} ngay tuong duong voi {year} nam {week} tuan {days} ngay");
        }
    }


}
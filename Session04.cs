using System;

public class Program
{
    public static void Main()
    {
        //baitap01();
        //baitap02();
        //baitap03();
        //baitap04();
        //baitap05();
        //baitap06();
        //baitap0701();
        //baitap0702();
        baitap0703();
        //baitap08();
        //baitap09();
        //baitap10();
    }
    static void baitap01()
    {
        Console.WriteLine("Nhap so a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} la so chan");
        }
        else Console.WriteLine($"{a} la so le");

    }
    static void baitap02()
    {
        Console.WriteLine("Nhap 3 so a, b, c: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            if (a > c) Console.WriteLine($"a = {a} la so lon nhat");
            else Console.WriteLine($"c = {c} la so lon nhat");
        }
        else if (b > c) Console.WriteLine($"b = {b} la so lon nhat");
        else Console.WriteLine($"c = {c} la so lon nhat");
    }
    static void baitap03()
    {
        Console.WriteLine("Nhap gia tri x, y: ");
        double x = Convert.ToInt32(Console.ReadLine());
        double y = Convert.ToInt32(Console.ReadLine());
        if (x > 0 && y > 0) Console.WriteLine($"Toa do ({x}, {y}) nam trong phan tu thu nhat");
        else if (x > 0 && y < 0) Console.WriteLine($"Toa do ({x}; {y}) nam trong phan tu thu tu");
        else if (x < 0 && y > 0) Console.WriteLine($"Toa do ({x}; {y}) nam trong phan tu thu hai");
        else Console.WriteLine($"Toa do ({x}; {y}) nam trong phan tu thu ba");
    }
    static void baitap04()
    {
        Console.WriteLine("Nhap so do do dai ba canh cua tam giac: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        if (a + b < c && a + c < b && b + c < a) Console.WriteLine("Ba canh vua nhap khong phai la ba canh cua mot tam giac");
        else if (a + b == c && a + c == b && b + c == a) Console.WriteLine("Ba canh vua n hap la mot duong thang");
        else if (a == b && b == c) Console.WriteLine("Tam giac deu");
        else if (a == b || b == c || a == c) Console.WriteLine("Tam giac can");
        else if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b) Console.WriteLine("Tam giac vuong");
        else Console.WriteLine("Ba canh vua nhap la tam giac thuong");
    }
    static void baitap05()
    {
        int sum = 0;
        Console.WriteLine("Nhap 10 so: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Nhap so thu {i + 1}: ");
            int a = Convert.ToInt32(Console.ReadLine());
            sum += a;
        }
        double avg = sum / 10.0;
        Console.WriteLine($"\nTrung binh cong cua 10 so vua nhap la: {avg}");
    }
    static void baitap06()
    {
        Console.WriteLine("Nhap so nguyen duong n: ");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            int n = a * i;
            Console.WriteLine($" {a} * {i} = {n}");
        }
    }
    static void baitap0701()
    {
        Console.WriteLine("Nhap so dong: ");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write($"{j} ");
            Console.Write("\n");

        }
    }
    static void baitap0702()
    {
        int b = 1;
        Console.WriteLine("Nhap so dong: ");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{b} ");
                ++b;
            }
            Console.Write($"\n");
        }
    }
    static void baitap0703()
    {
        int b = 1;
        int c;
        Console.WriteLine("Nhap so dong: ");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= a; i++)
        {
            for (c = 1; c <= a - i; c++) Console.Write(" ");
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{b} ");
                ++b;
            }
            Console.Write($"\n");
        }

    }
    static void baitap08()
    {
        double sum = 0.0;
        Console.WriteLine("Nhap so n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i < n)
            {
                Console.Write($"1/{i} + ");
                sum += 1 / (float)i;
            }
            if (i == n)
            {
                sum += 1 / (float)i;
                Console.WriteLine($"1/{i} ");
            }
        }
        Console.WriteLine($"Tong cua day la: {sum}");
    }
    static void baitap09()
    {
        int n, sum;
        Console.WriteLine("Nhap so nguyen duong a va b: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            n = 1;
            sum = 0;
            while (n < i)
            {
                if (i % n == 0) sum = sum + n;
                n++;
            }
            if (sum == i) Console.WriteLine($"So {i} la so hoan hao");
        }
    }
    static void baitap10()
    {
        int a = 0;
        Console.WriteLine("Nhap so nguyen duong n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                a++;
                Console.WriteLine($"{n} khong phai so nguyen to");
                break;
            }
        }
        if (a == 0 && n != 1) Console.WriteLine($"{n} la so nguyen to");
    }
}



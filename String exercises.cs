using System;
					
public class String
{
	public static void Main(string [] args)
	{
		//string01();
		//string02();
		//string03();
		string04();
	}
	static void string01()
        {
            Console.WriteLine("input the string: ");
            string a = Console.ReadLine();
            Console.WriteLine($"the string you entered is:{a} ");
        }
        static void string02()
        {
            Console.WriteLine("input the string: ");
            string a = Console.ReadLine();
            int b = 0;
            foreach (char chr in a)
            {
                b += 1;
            }
            Console.WriteLine($"length of the string is : {b}");
        }
		static void string03()
		{
			Console.WriteLine("input the string: ");
            string a = Console.ReadLine();
			int b = 0;
			Console.WriteLine("The characters of the string is:");
			while(b <= a.Length - 1)
			{
				Console.Write("{0} ",a[b]);
				b++;
			}
				Console.WriteLine("\n\n");
		}
		static void string04()
		{
			Console.WriteLine("input the string: ");
            string a = Console.ReadLine();
			int b = a.Length - 1;
			Console.WriteLine("The characters of the string is:");
			while(b >=0)
			{
				Console.Write("{0} ",a[b]);
				b--;
			}
				Console.WriteLine("\n\n");
		}
		static void string05()
		{
			
		}

}

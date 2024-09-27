using System;
public class String
{
  public static void Main(string[]args)
  {
     string inputString = Inputthestring("");
     Console.WriteLine("The string is: " + inputString);
     int length = Lengthofstring("");
      Console.WriteLine("The length of string is: " + length );
    seperatecharacters("");
    int word = Countwords("");
    Console.WriteLine("The number of words: " + word);
    compare("");
    int [] result = alphabetdigitspecial("");
    Console.WriteLine($"The number of alphabets: {result[1]}");
    Console.WriteLine($"The number of digits: {result[0]}");
    Console.WriteLine($"The number of special characters: {result[2]}");
    int [] result1 = vowelsandconsonants("");
    Console.WriteLine($"The number of vowels: {result1[0]}");
    Console.WriteLine($"The number of consonants: {result1[1]}");
    bool substr= substringpresent("");
    if (substr == true) Console.WriteLine("The substring exists in the string");
    else Console.WriteLine("The substring does not exist in the string");
    positionofsubstring("");
    checkchar(' ');
    int result2 = substringappears(" ");
    Console.WriteLine($"The substring appears {result2} times");
    string result3 = insertsubstring("");
    Console.WriteLine("The string after insertion is: " + result3);
  }
  static string Inputthestring (string s)
  {
    Console.WriteLine("input the string: ");
    s=Console.ReadLine();
    return s;
  }
  static int Lengthofstring (string s)
  {
    Console.WriteLine("Input the string: ");
    s=Console.ReadLine();
    int b = 0;
    foreach(char chr in s)
    {
      b++;
      if (chr == ' ') b--;
    }
    return b;
  }
  static void seperatecharacters (string s)
  {
    Console.WriteLine("Input the string: ");
    s=Console.ReadLine();
    int b = s.Length - 1;
    Console.WriteLine("The characters of the string is: ");
    while (b >= 0)
    {
      Console.WriteLine(s[b]);
      b--;
    }
    Console.WriteLine("\n\n");
  }
  static int Countwords (string s)
  {
    Console.WriteLine("Input the string: ");
    s = Console.ReadLine();
    int b = 0;
    int c = 0;
    s = s.Trim();
    foreach (char chr in s)
    {
      c++;
      if (chr == ' ') b++;
    }
    if (!string.IsNullOrEmpty(s)) b++;
    int space = b + 1;
    return space;
  }
  static void compare(string s)
  {
    Console.WriteLine("Input the string1: ");
    string s1 = Console.ReadLine();
    Console.WriteLine("Input the string2: ");
    string s2 = Console.ReadLine();
    if (s1.Length == s2.Length)
    {
      foreach (char chr1 in s1)
      {
        foreach(char chr2 in s2)
        
          if (chr1 != chr2)
          {
           Console.WriteLine("Two strings are not equal");
            break;
          }
      }
       Console.WriteLine("Two strings are equal");
    }
    else if (s1.Length < s2.Length) Console.WriteLine ("s1 is shorter than s2");
    Console.WriteLine("s1 is longer than s2");
  }
  static int [] alphabetdigitspecial(string s)
  {
    Console.WriteLine("Input the string: ");
    s = Console.ReadLine();
    int b = 0;
    int c = 0;
    int d = 0;
    s= s.ToLower();
    foreach(int e in s)
    {
      if (e >= '0' && e <= '9') b++;
      else if (e >= 'a' && e <= 'z') c++;
      else d++;
    }
    int [] result = {b,c,d};
    return result;
  }
  static int [] vowelsandconsonants(string s)
  {
    Console.WriteLine("Input the string: ");
    s = Console.ReadLine();
    int b = 0;
    int vowels = 0;
    int conso = 0;
    foreach (char chr in s)
    {
      b++;
      if (chr == 'a' || chr == 'e' || chr == 'i' || chr == 'o' || chr == 'u')
      vowels++;
      if (chr == ' ') b--;
    }
    conso = b - vowels;
    int [] result = {vowels,conso};
    return result;
  }
  static bool substringpresent (string s)
  {
    Console.WriteLine("Input the string: ");
    s = Console.ReadLine();
    Console.WriteLine("Input the substring: ");
    string substring = Console.ReadLine();
    bool m;
    if (s.Contains(substring)) m = true;
    else m = false;
    return m;
  }
  static void positionofsubstring (string s)
  {
    Console.WriteLine("Input the string: ");
    s = Console.ReadLine();
    Console.WriteLine("Input the substring: ");
    string findsbstr = Console.ReadLine();
    int index = s.IndexOf(findsbstr);
    if (index < 0 ) Console.WriteLine("The substring does not exist in the string");
    else Console.WriteLine($"\nThe substring is found at index {index}");
  }
  static void checkchar (char chr)
  {
    Console.WriteLine("Input the string: ");
      chr = (char)Console.Read();
    if (chr >= 'a' && chr <= 'z' || chr >= 'A' && chr <= 'Z' ) Console.WriteLine("The character is a letter");
    else if (chr >= '0' && chr <= '9') Console.WriteLine("The character is a digit");
    else Console.WriteLine("The character is a special character");
  }
  static int substringappears(string s)
  {
    Console.WriteLine("Input the string: ");
    s = Console.ReadLine();
    Console.WriteLine("Input the substring: ");
    string substring = Console.ReadLine();
    int str = 0;
    int cnt = -1;
    int idx = -1;
    while(str != -1)
    {
      str = s.IndexOf(substring, idx + 1);
      cnt++;
      idx = str;
    }
    return cnt;
  }
  static string insertsubstring (string s)
  {
    Console.WriteLine("Input the string: ");
    s = Console.ReadLine();
    Console.WriteLine("Input the substring: ");
    string substring = Console.ReadLine();
    Console.WriteLine("Input the string to be searched for: ");
    string findstr = Console.ReadLine();
    int idx = s.IndexOf(findstr);
    substring = " " + substring.Trim() + " ";
    s = s.Insert(idx, substring);
    return s;
  }
}

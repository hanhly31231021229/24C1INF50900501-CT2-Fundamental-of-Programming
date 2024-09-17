using System;
namespace ConsoleApp1
{
  internal class MultipleArrays
  {
    static void RandomData(int [,] a)
    {
      Random rnd = new Random();
      for (int i = 0; i < a.GetLength(0); i++)
      {
        for (int j = 0; j < a.GetLength(1); j++)
          a[i,0] = rnd.Next(100);
      }
    }    
    static void PrintArraySequence(int [,] a)
    {
      for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
          Console.WriteLine($"{a[i,j]} ");
      Console.WriteLine();
    }
    static void PrintArray(int [,] a)
    {
      foreach(int value in a)
        Console.Write($"{value} ");
    }
    ///adding two matrixes
    static int [,] AddMatrix(int [,] a, int [,] b)
    {
      int [,] summatrix = new int [2,2];
      Console.WriteLine("Nhap phan tu ma tran 1: ");
       a[2,2] = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap phan tuma tran 2: ");
       b[2,2] = int.Parse(Console.ReadLine());
      for (int i = 0; i < a.Length; i++)
      {
        for (int j = 0; j < b.Length; j++)
         summatrix[2,2] = a[2,2] + b[2,2];
      }
      return summatrix;
    }
     ///subtraction of two matrixes
    static int [,] SubMatrix(int [,] a, int [,] b)
    {
      int [,] submatrix = new int [2,2];
      Console.WriteLine("Nhap phan tu ma tran 1: ");
       a[2,2] = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap phan tu ma tran 2: ");
       b[2,2] = int.Parse(Console.ReadLine());
      for (int i = 0; i < a.Length; i++)
      {
        for (int j = 0; j < b.Length; j++)
         submatrix[2,2] = a[2,2] - b[2,2];
      }
      return submatrix;
    }
    ///multiplication of two matrixes
    static int [,] MultiplyMatrix(int [,] a, int [,] b)
    {
      int [,] mulmatrix = new int [2,2];
      Console.WriteLine("Nhap phan tu ma tran 1: ");
       a[2,2] = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap phan tu ma tran 2: ");
       b[2,2] = int.Parse(Console.ReadLine());
      for (int i = 0; i <= a.Length-1; i++)
      {
        for (int j = 0; j <= b.Length-1; j++)
         mulmatrix[2,2] = a[2,2] * b[2,2];
      }
      return mulmatrix;
    }
    ///transpose of a matrix
    static int [,] TransposeMatrix(int [,] a,int[,] b)
    {
      int [,] transposematrix = new int [2,2];
      Console.WriteLine("Nhap phan tu ma tran : ");
       a[2,2] = int.Parse(Console.ReadLine());
      for (int i = 0; i < a.Length - 1; i++)
      {
        for(int j = 0; j<a.Length - 1; j++)
        {
          a[i,j] = a[j,i];
        }
      }
      return a;
    }
    ///sum of the right diagonals of a matrix
    static int SumRightDiagonal(int [,] a)
    {
      int sumrd=0;
      Console.WriteLine("Nhap phan tu ma tran 1: ");
      a[2,2] = int.Parse(Console.ReadLine());
      for(int i = 0; i<= a.Length - 1; i++)
      {
        for (int j = 0; j <= a.Length - 1; j++)
        if (i == j) sumrd += a[i,j];
      }
      return sumrd;
    }
    ///sum of the left diagonals of a matrix
    static int SumLeftDiagonal(int [,] a)
      {
        int sumld=0;
        Console.WriteLine("Nhap phan tu ma tran 1: ");
        a[2,2] = int.Parse(Console.ReadLine());
        for(int i = 0; i<= a.Length - 1; i++)
        {
          for (int j = 0; j <= a.Length - 1; j++)
          sumld = a[i,j]+a[j,i];
        }
        return sumld;
      }
    ///sum of rows and columns in a matrix
    static int [,] SumRowsAndColumns(int [,] a)
    {
      int [] rsum = new int [2];
      int [] csum = new int [2];
      Console.WriteLine("Nhap phan tu ma tran 1: ");
      a[2,2] = int.Parse(Console.ReadLine());
      for (int i = 0; i < a.Length; i++)
      {
        for (int j =0; j < a.Length; j++)
        rsum[i] += a[i,j];
      }
      for (int i = 0; i < a.Length; i++)
      {
        for (int j= 0; j <a.Length; j++)
        csum[i] += a[j,i];
      }
      Console.Write($"{a}");
      Console.Write($"\n{rsum}");
      Console.Write($" \n{csum}");
      return a;
    }
    ///print the lower triangular of a given matrix
    static int[,] LowerTriangularMatrix(int [,] a)
    {
      Console.WriteLine("Nhap phan tu ma tran :");
      a [3,3] = int.Parse(Console.ReadLine());
      for (int i =0; i < a.Length;i++)
      {
        for(int j =0; j< a.Length; j++)
        {
          if (i > j) a[i,j] = 0;
        }
      }
      return a;
    }
    ///print the upper triangular of a given matrix
    static int[,] UpperTriangularMatrix(int [,] a)
    {
      Console.WriteLine("Nhap phan tu ma tran :");
      a [3,3] = int.Parse(Console.ReadLine());
      for (int i =0; i < a.Length;i++)
      {
        for(int j =0; j< a.Length; j++)
        {
          if (i < j) a[i,j] = 0;
        }
      }
      return a;
    }
    ///caculate the determinant of a 3x3 matrix
    static int DeterminantOf3x3Matrix(int [,] a)
    {
      int det = 0;
      Console.WriteLine("Nhap phan tu ma tran :");
      a [3,3] = int.Parse(Console.ReadLine());
      for (int i =0; i < a.Length;i++)
      {
        det = det + (a[0, i] * (a[1, (i + 1) % 3] * a[2, (i + 2) % 3] - a[1, (i + 2) % 3] * a[2, (i + 1) % 3]));
      }
      return det;
    }
    ///determine whether it is a sparse matrix.
    static bool SparseMatrix(int [,] a)
    {
      int count = 0;
      Console.WriteLine("Nhap phan tu ma tran :");
      a[4,4] = int.Parse(Console.ReadLine());
      for(int i = 0; i < a.Length; i++)
        {
          for(int j = 0; j < a.Length; j++)
            {
                if (a[i,j] ==0) ++count;
            }
        }
      if (count > (a.Length * a.Length) / 2) return true;
      return false;
    }
    ///two matrices and check equality
    static bool MatrixEquality(int [,] a, int [,] b)
    {
      int flag = 1;
      Console.WriteLine("Nhap phan tu ma tran 1: ");
      a[2,2] = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap phan tu ma tran 2: ");
      b[2,2] = int.Parse(Console.ReadLine());
      for (int i = 0; i < a.Length; i++)
      {
        for (int j = 0; j < b.Length; j++)
        {
          if (a[i,j] != b[i,j])
          {
            flag =0;
            break;
          }
        }
      }
      if (flag ==1) return true;
      else return false;
    }
    /// check whether a matrix is an identity matrix
    static bool IdentityMatrix(int [,] a)
    {
      int flag = 1;
      Console.WriteLine("Nhap phan tu ma tran 1: ");
      a[5,5] = int.Parse(Console.ReadLine());
      for (int i = 0; i < a.Length; i++)
      {
        for (int j = 0; j < a.Length; j++)
        {
          if (i == j)
          {
            if (a[i,j] != 1)
            {
              flag = 0;
              break;
            }
          }
          else
          {
            if (a[i,j] != 0)
            {
              flag = 0;
              break;
            }
          }
        }
      }
      if (flag ==1) return true;
      return false;
    }
    ///get only odd values from a given integer array
    static int [] GetOddValues(int [,] a)
    {
      int [] oddvalue = new int [a.Length];
      Console.WriteLine("Nhap phan tu ma tran 1: ");
      a [5,5] = int.Parse(Console.ReadLine());
      for(int i = 0; i < a.Length;i++)
      {
        for(int j =0; j < a.Length;j++)
        {
          if (a[i,j] % 2 != 0)
          {
            oddvalue[i] = a[i,j];
          }
        }
      }
      return oddvalue;
    }
    /// removes all duplicate elements from a given array and returns an updated array
    static bool  RemoveDuplicateElements()
    {
      object [] a = new object [8];
      a[0] = 25;
      a[1] = "Anna";
      a[2] = false;
      a[3] = 25;
      a[4] = System.DateTime.Now;
      a[5] = 112.22;
      a[6] = "Anna";
      a[7] = false;
      Console.WriteLine("Original array elements: ");
      for (int i = 0; i < a.Length; i++)
      Console.WriteLine(a[i]);
      for (int i = 0; i < a.Length; i++)
      {
        if (a[i] == a[i+1])
        {
          for (int j = i; j < a.Length - 1; j++)
          {
            a[j] = a[j+1];
          }
          return true;
        }
      }
      return false;
    }
    ///find the missing number in a given array of numbers between 10 and 20
    static int FindMissingNumber(int [] c)
    {
      int [] b = new int [10] {10,11,12,13,15,16,17,18,19,20};
      for (int i = 0; i < b.Length; i++)
        {
          if (b[i+1] - b [i] != 1)
          {
            return b[i+1] - 1;
          }
        }
        return 0;
    }
    ///calculate the sum of the two lowest negative numbers in a given array of integers.
    static int SumOfTwoLowestNegativeNumbers(int [] c)
      {
        int sum;
      int[] nums = { -10, -11, -12, -13, -14, 15, 16, 17, 18, 19, 20 };
      int min1 = nums[0];
      int min2 = nums[0];
        foreach(int val in nums)
        {
          if (min1 < val) min1 = val;
        }
        foreach(int value in nums)
        {
          if (min2 < value && value != min1) min2 = value;
        }
        sum = min1 + min2;
        return sum;
      }
    ///re-arrange the elements in a given array ofnumbers and check whether the numbers are consecutive or not.
      static bool CheckConsecutiveNumbers(int [] c)
      {
        int [] nums = { -1,-2,-3,0,1,2,3 };
        Array.Sort(nums);
        for (int i = 1; i < nums.Length; i++)
        {
          if (nums[i] - nums[i-1] != 1)
          return false;
        }
        return true;
      }
    ///calculates the smallest gap between numbers in an array of integers
    static int SmallestGap(int [] c)
      {
        int min;
        int [] nums = {200,300,250,151,162};
        int [] result = new int [nums.Length];
        for (int i = nums.Length; i > 0; i--)
        {
          result[i] = nums[i] - nums[0];
        }
        for (int i = nums.Length; i > 1; i--)
        {
          result[i] = nums[i] - nums[1];
        }
        for (int i = nums.Length; i > 2; i--)
        {
          result[i] = nums[i] - nums[2];
        }
        for (int i = nums.Length; i > 3; i--)
        {
          result[i] = nums[i] - nums[3];
        }
        min = result[0]; 
          for (int i = 1; i < result.Length; i++)
          {
            min = Math.Min(min, result[i]); 
          }
        return min;
      }
      ///Check whether the digit is present in this array of numbers.
      static bool CheckDigit(int [] c)
      {
        int a, b;
        int [] nums = {7,5,85,9,11,23,18};
        int n = 5;
        for (int i = 0; i < nums.Length; i++)
        {
          if (nums[i]  > 9 )
          {
            a = nums[i ] /10;
            b = nums[i] %10;
            if (a == n || b == n) return true;
          }
          else if(nums[i] == n) return true;
        }
        return false;
        
      }
      ///Calculate the sum of all prime numbers in an array.
      static int SumOfPrimeNumbers(int [] c)
      {
        int prime=0;
        int n = 0;
        int [] nums = {7,5,85,9,11,23,18};
        for (int i = 0; i < nums.Length; i++)
        {
          for (int j = 0; j < nums[i]/2; j++)
          {
            if (nums[i] % j == 0)
            {
              n++;
              break;
            }
          }
          if (n ==0 && nums[i] != 1) prime += nums[i];
        }
        return prime;
      }
      ///find the smallest positive integer that is not present in that array
      static int SmallestPositiveInteger(int [] c)
      {
        int [] nums  = {-1,-2,0,1,3,4,5,6};
        for (int i =0; i < nums.Length; i++)
        {
          if (nums[i] < 0) break;
          else if (nums[i+1] - nums[i] != 1) return nums[i] + 1;
        }
        return 0;
      }
      ///find two numbers in an array of integers whose product is equal to a given number
      static int [] FindTwoNumbers(int [] c)
      {
        int [] nums = {10,18,39,75,100};
        int [] result = new int [2];
        int n = 180;
        foreach (int x in nums)
        {
          foreach (int y in nums)
          {
            if (x * y == n)
            {
               result[0] = x;
               result [1] = y;
            }
          }
        }
        return result;
      }  
    public static void Main (string[] args)
    {
      int [,] a = new int[3,5];
      int [] nums = {7,5,85,9,11,23,18};
      int [] res = {7,5,85,9,11,23,18};
      int [] num  = {-1,-2,0,1,3,4,5,6};
      int [] product = {10,18,39,75,100};
      RandomData(a);
      PrintArraySequence(a);
      ///print the matrix of an 2d 3x3 array
      int [,] b = new int[3,3] { {1,2,3}, {4,5,6}, {7,8,9} };
      Console.WriteLine($"{b}");
      PrintArray(b);
      AddMatrix(a,b);
      SubMatrix(a,b);
      MultiplyMatrix(a,b);
      TransposeMatrix(a,b);
      SumRightDiagonal(a);
      SumLeftDiagonal(a);
      SumRowsAndColumns(a);
      LowerTriangularMatrix(a);
      UpperTriangularMatrix(a);
      bool r1 = SparseMatrix(a);
      if (r1 == true) Console.WriteLine("The matrix is sparse");
      else Console.WriteLine("The matrix is not sparse");
      bool r2 = MatrixEquality(a,b);
      if(r2==true) Console.WriteLine("Two matrices are equal");
      else Console.WriteLine("Two matrices are not equal");
      bool r3 = IdentityMatrix(a);
      if(r3==true) Console.WriteLine("The matrix is an identity matrix");
      else Console.WriteLine("The matrix is not an identity matrix");
      GetOddValues(a);
      bool r4 = RemoveDuplicateElements();
      if (r4==true) 
      {
        Console.WriteLine("The matrix has duplicate elements");
        Console.WriteLine($"The new matris: {a}");
      }
      else Console.WriteLine("The matrix has no duplicate elements");
      FindMissingNumber(nums);
      bool r5 = CheckConsecutiveNumbers(nums);
      if (r5==true) Console.WriteLine("The numbers are consecutive");
      else Console.WriteLine("The numbers are not consecutive");
      SmallestGap(nums);
      bool r6 = CheckDigit(nums);
      if (r6==true) Console.WriteLine("The digit is present in the array");
      else Console.WriteLine("The digit is not present in the array");
      SumOfPrimeNumbers(res);
      SmallestPositiveInteger(num);
      FindTwoNumbers(product);
    }
   }
}

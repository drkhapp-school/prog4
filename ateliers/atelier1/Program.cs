using System;

namespace atelier1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // Question 7
      int x, y, z;

      x = Int32.MaxValue;
      y = x;
      z = x + y;
      Console.WriteLine(z);

      // Question 9
      int firstNumber;
      int secondNumber;
      int result;

      Console.WriteLine("First number:");
      firstNumber = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Second number:");
      secondNumber = Convert.ToInt32(Console.ReadLine());

      result = firstNumber + secondNumber;
      Console.WriteLine("Answer: " + result);
    }
  }
}
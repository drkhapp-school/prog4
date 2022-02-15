using System;

namespace atelier2
{
  internal class Program
  {
    public static UInt64 IsPrime(UInt64 input)
    {
      switch (input)
      {
        case 1:
        case 2:
          return 1;
        default:
        {
          UInt64 test = 2;
          if (input % test == 0)
          {
            return 2;
          }

          test++;
          UInt64 max = (UInt64) Math.Sqrt(input);
          while (test < max && input % test != 0)
          {
            test += 2;
          }

          return input % test != 0 ? 1 : test;
        }
      }
    }

    public static void Main(string[] args)
    {
      UInt64 input;
      Console.WriteLine("Veuillez entrer un nombre: ");
      input = Convert.ToUInt64(Console.ReadLine());

      UInt64 divider = IsPrime(input);


      if (divider == 1)
      {
        Console.WriteLine(input + " est un nombre premier!");
      }
      else
      {
        Console.WriteLine("Le nombre " + input + " n'est pas un nombre premier car il est divisible par " + divider);
      }
    }
  }
}
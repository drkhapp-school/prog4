using System;

namespace atelier2
{
  internal class Program
  {
    public static ulong IsPrime(ulong input)
    {
      switch (input)
      {
        case 1:
        case 2:
          return 1;
        default:
        {
          ulong test = 2;
          if (input % test == 0) return 2;

          test++;
          var max = (ulong) Math.Sqrt(input);
          while (test < max && input % test != 0) test += 2;

          return input % test != 0 ? 1 : test;
        }
      }
    }

    public static void Main(string[] args)
    {
      ulong input;
      Console.WriteLine("Veuillez entrer un nombre: ");
      input = Convert.ToUInt64(Console.ReadLine());

      var divider = IsPrime(input);


      if (divider == 1)
        Console.WriteLine(input + " est un nombre premier!");
      else
        Console.WriteLine("Le nombre " + input + " n'est pas un nombre premier car il est divisible par " + divider);
    }
  }
}
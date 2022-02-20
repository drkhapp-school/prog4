using System;

namespace atelier3
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Planet earth = new Planet("earth", 6371, 1);
      Planet mars = new Planet("mars", 3389.5, 0.107);
      Planet venus = new Planet("venus", 6051.8, 0.815);
      Planet saturn = new Planet("saturn", 58232, 95.16);
      Console.WriteLine(earth.ToString());
      Console.WriteLine(mars.ToString());
      Console.WriteLine(venus.ToString());
      Console.WriteLine(saturn.ToString());
    }
  }
}
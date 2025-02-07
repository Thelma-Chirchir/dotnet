using System;
using System.Diagnostics.CodeAnalysis;

public class Continue
{
  public static void Main(string[] args)
  {
    int sum = 0;
    for (int i = 1; i <= 3; i++)
    {
      if (i == 2)
      {
        continue;
      }
      sum += 1;

    }
    Console.WriteLine(sum);
  }
}
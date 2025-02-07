using System;

public class Break
{
  public static void Main(string[] args)
  {
    int num = 1;
    while (num <= 10)
    {
      if (num == 3)
      {
        break;
      }
      Console.WriteLine(num);
      num++;
    }
  }
}
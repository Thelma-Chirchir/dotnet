using System;

public class Coffee
{
  public static void Main(string[] args)
  {
    int coffee = 2;
    switch (coffee)
    {
      case 0:
        Console.WriteLine("No coffee ordered.");
        break;
      case 1:
        Console.WriteLine("1 cup of coffee ordered.");
        break;
      case 2:
        Console.WriteLine("2 cups of coffee ordered.");
        break;
      default:
        Console.WriteLine("Invalid number of cups.");
        break;
    }
  }
}
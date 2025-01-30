using System;

public class Program
{
  public static void Main(string[] args)
  {
    int x = 15;
    x += 5; // x = x + 5;
    Console.WriteLine(x); // Output: 20

    x -= 5; // x = x - 5;
    Console.WriteLine(x); // Output: 15

    x *= 5; // x = x * 5;
    Console.WriteLine(x); // Output: 75

    x /= 5; // x = x / 5;
    Console.WriteLine(x); // Output: 15

    x %= 5; // x = x % 5;
    Console.WriteLine(x); // Output: 0

    //take away
    int bal = 20000
    bal -= 5000; // bal = bal - 5000;
    Console.WriteLine(bal);
  }
}
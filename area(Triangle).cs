using System;

public class Area
{
  public static void Main(string[] args)
  {
    Console.Write("The base of the triangle is: ")
    double baseLength = Convert.ToDouble(Console.ReadLine());

    Console.Write("The height of the triangle is: ")
    double height = Convert.ToDouble(Console.ReadLine());

    double area = (baseLength * height) / 2;
    Console.WriteLine("$The area of the triangle is: {area}");
  }
}
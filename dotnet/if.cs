using System;

public class If
{
  public static void Main(string[] args)
  {
    string day = "Monday";
    if (!(day == "Sunday"))
    {
      Console.WriteLine("Closed");
    }
    else
    {
      Console.WriteLine("Open");
    }
  }
}


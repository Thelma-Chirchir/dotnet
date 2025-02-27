using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace sololearn;

public class Program
{
  enum TrafficLights { Green, Red, Yellow };
  public static void Main(string[] args)
  {
    TrafficLights x = TrafficLights.Red;
    switch (x)
    {
      case TrafficLights.Green:
        Console.WriteLine("Go!");
        break;
      case TrafficLights.Red:
        Console.WriteLine("Stop!");
        break;
      case TrafficLights.Yellow:
        Console.WriteLine("Caution!");
        break;
    }

  }
}
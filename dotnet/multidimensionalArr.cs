using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
      for (int i = 0; i < num.GetLength(0); i++)
      {
        // Loop through columns
        for (int j = 0; j < num.GetLength(1); j++)
        {
          Console.Write(num[i, j] + " ");
        }
        Console.WriteLine();
      }
    }
  }
}
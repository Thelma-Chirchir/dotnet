using System;

class Method
{
  static void Main()
  {
    Console.Write("Enter your name: ");
    string userName = Console.ReadLine();
    Console.WriteLine(WelcomeMessage(userName));
  }

  static string WelcomeMessage(string name)
  {
    return $"Welcome, {name}!";
  }
}

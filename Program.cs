using System;

namespace _Guesser_
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1;
      var max = 100;

      var pick = (max + min) / 2;
      var userAnswer = "";

      System.Console.WriteLine($"Think of a number between {min} and {max}");

      while (userAnswer != "equal")
      {
        System.Console.WriteLine($"Is your number higher or lower or equal to {pick}");
        userAnswer = Console.ReadLine();
        if (userAnswer == "higher")
        {
          min = pick;
          pick = (max + min) / 2;
        }
        if (userAnswer == "lower")
        {
          max = pick;
          pick = (max + min) / 2;
        }
        if (userAnswer == "equal")
        {
          System.Console.WriteLine("VICTORY");
        }
      }
    }
  }
}

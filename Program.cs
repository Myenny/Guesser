using System;

namespace _Guesser_
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1;
      var max = 100;
      //   var currentPick = pick;
      var pick = (max + min) / 2;
      var userAnswer = "";

      // set a min/max
      System.Console.WriteLine($"Think of a number between {min} and {max}");
      // tell user to pick #
      // pick the first guess of user #
      // ask if higher or lower?
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

      // reset the number range
    }
  }
}

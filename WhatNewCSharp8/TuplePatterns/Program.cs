using System;

namespace TuplePatterns
{
    class Program
    {
        public static string RockPaperScissors(string first, string second)
        {
            if (first == "rock" && second == "paper")
            {
                return "rock is covered by paper. Paper wins.";
            }
            else if (first == "rock" && second == "scissors")
            {
                return "rock breaks scissors. Rock wins.";
            }
            else if (first == "paper" && second == "rock")
            {
                return "paper covers rock. Paper wins.";
            }
            else if (first == "paper" && second == "scissors")
            {
                return "paper is cut by scissors.Scissors wins.";
            }
            else if (first == "scissors" && second == "rock")
            {
                return "rock breaks scissors. Rock wins.";
            }
            else if (first == "scissors" && second == "paper")
            {
                return "scissors cuts paper. Scissors wins.";
            }
            else
            {
                return "tie";
            }
        }

        //public static string RockPaperScissors(string first, string second)
        //=> (first, second) switch
        //{
        //    ("rock", "paper") => "rock is covered by paper. Paper wins.",
        //    ("rock", "scissors") => "rock breaks scissors. Rock wins.",
        //    ("paper", "rock") => "paper covers rock. Paper wins.",
        //    ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
        //    ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
        //    ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
        //    (_, _) => "tie"
        //};

        static void Main(string[] args)
        {
            var result = RockPaperScissors("paper", "rock");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

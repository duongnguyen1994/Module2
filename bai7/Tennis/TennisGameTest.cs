using System;

namespace Tennis
{
    class TennisGameTest
    {
        static void Main(string[] args)
        {
            TennisGame tennisGame = new TennisGame();
            Console.WriteLine(tennisGame.GetScore("Federer", "Nadal", 2, 1));
        }
    }
}

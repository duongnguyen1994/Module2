using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    class TennisGame
    {
        const int love = 0;
        const int fifteen = 1;
        const int thirty = 2;
        const int forty = 3;
        public string GetScore(string firstPlayerName, string secondPlayerName, int firstPlayerScore, int secondPlayerScore)
        {
            if(firstPlayerScore == secondPlayerScore && firstPlayerScore>2)
            {
                return "Deuce";
            }
            else if(firstPlayerScore>=3 && secondPlayerScore>=3)
            {
                return AdvantageSet(firstPlayerName, secondPlayerName,firstPlayerScore, secondPlayerScore);
            }
            else if(firstPlayerScore == secondPlayerScore)
            {
                return $"{ShowScore(firstPlayerScore)}-All";
            }          
            return $"{ShowScore(firstPlayerScore)}-{ShowScore(secondPlayerScore)}";       
        }
        public string ShowScore(int playerScore)
        {
            switch(playerScore)
            {
                case love:
                    return "Love";
                case fifteen:
                    return "Fifteen";
                case thirty:
                    return "Thirty";
                default:
                    return "Forty";
            }
        }
        public string AdvantageSet(string firstPlayerName, string secondPlayerName, int firstPlayerScore, int secondPlayerScore)
        {
            int scoreCompare = firstPlayerScore - secondPlayerScore;
            switch(scoreCompare)
            {
                case 1:
                    return $"Advantage {firstPlayerName}";
                case -1:
                    return $"Advantage {secondPlayerName}";
                case 2:
                    return $"Win for {firstPlayerName}";
                default:
                    return $"Win for {secondPlayerName}";
            }
        }
    }
}

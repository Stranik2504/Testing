using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockSissorsPaper
{
    public enum RSPLS { Rock, Scissors, Paper, Lizard, Spock }

    public class WinnerCheckerModified : IWinCheck
    {
        public Result Fight(int p1, int p2)
        {
            if (!IsValid(p1) || !IsValid(p2))
                throw new ArgumentException("Invalid move");

            RSPLS player1 = (RSPLS)p1;
            RSPLS player2 = (RSPLS)p2;

            if (player1 == player2)
                return Result.Draw;

            if ((player1 == RSPLS.Rock && player2 == RSPLS.Scissors) ||
                (player1 == RSPLS.Rock && player2 == RSPLS.Lizard) ||
                (player1 == RSPLS.Paper && player2 == RSPLS.Rock) ||
                (player1 == RSPLS.Paper && player2 == RSPLS.Spock) ||
                (player1 == RSPLS.Scissors && player2 == RSPLS.Paper) ||
                (player1 == RSPLS.Scissors && player2 == RSPLS.Lizard) ||
                (player1 == RSPLS.Spock && player2 == RSPLS.Rock) ||
                (player1 == RSPLS.Spock && player2 == RSPLS.Scissors) ||
                (player1 == RSPLS.Lizard && player2 == RSPLS.Paper) ||
                (player1 == RSPLS.Lizard && player2 == RSPLS.Spock))
            {
                return Result.Winner1;
            }

            return Result.Winner2;
        }

        public static bool IsValid(int p)
        {
            foreach (var item in Enum.GetValues(typeof(RSPLS)))
                if ((int)item == p)
                    return true;

            return false;
        }
    }
}

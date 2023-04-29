using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockSissorsPaper
{
    public enum RSP { Rock, Scissors = 3, Paper }
    public enum Result { Winner1, Winner2, Draw }

    public class WinnerChecker : IWinCheck
    {
        public Result Fight(int p1, int p2)
        {
            if (!IsValid(p1) || !IsValid(p2))
                throw new ArgumentException("Invalid move");

            if (p1 == p2)
                return Result.Draw;

            RSP player1 = (RSP)p1;
            RSP player2 = (RSP)p2;

            if (
                (player1 == RSP.Rock && player2 == RSP.Scissors) ||
                (player1 == RSP.Scissors && player2 == RSP.Paper) ||
                (player1 == RSP.Paper && player2 == RSP.Rock)
            )
                return Result.Winner1;

            return Result.Winner2;
        }

        public static bool IsValid(int p)
        {
            foreach (var item in Enum.GetValues(typeof(RSP)))
                if ((int)item == p)
                    return true;

            return false;
        }
    }
}

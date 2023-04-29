using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockSissorsPaper
{
    public static class WinCheckerFabric
    {
        public static IWinCheck Create(bool isClassicGame)
        {
            if (!isClassicGame)
                return new WinnerCheckerModified();

            return new WinnerChecker();
        }
    }
}

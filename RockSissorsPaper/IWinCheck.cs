using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockSissorsPaper
{
    public interface IWinCheck
    {
        public Result Fight(int p1, int p2);
    }
}

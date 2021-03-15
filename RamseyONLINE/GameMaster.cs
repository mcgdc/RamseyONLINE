using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamseyONLINE
{
    public static class GameMaster
    {
        public static (bool, Player) CheckIfEnd(Graph graph, GraphKind H_kind, int H_n, int numberOfIsolatedVertixes, int numberOfEdgesDrawn)
        {
            if (numberOfEdgesDrawn == numberOfIsolatedVertixes * (numberOfIsolatedVertixes - 1) / 2)
                return (true, Player.Painter);
            else return (false, Player.NotDefined);
        }
    }
}

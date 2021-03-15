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
            if (H_kind == GraphKind.clique)
                if (CheckForClique(graph, H_n)) return (true, Player.Builder);
                else if (CheckForStar(graph, H_n)) return (true, Player.Builder);


            if (numberOfEdgesDrawn == numberOfIsolatedVertixes * (numberOfIsolatedVertixes - 1) / 2)
                return (true, Player.Painter);
            else return (false, Player.NotDefined);
        }

        private static bool CheckForStar(Graph graph, int H_n)
        {
            return false;
        }
        private static bool CheckForClique(Graph graph, int H_n)
        {
            return false;
        }
    }
}

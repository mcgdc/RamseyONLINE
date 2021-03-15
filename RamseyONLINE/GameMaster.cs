using System;
using System.Collections.Generic;
using System.Drawing;
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
            {
                if (CheckForClique(graph, H_n)) return (true, Player.Builder);
            }
            else if (CheckForStar(graph, H_n)) return (true, Player.Builder);


            if (numberOfEdgesDrawn == numberOfIsolatedVertixes * (numberOfIsolatedVertixes - 1) / 2)
                return (true, Player.Painter);
            else return (false, Player.NotDefined);
        }

        private static bool CheckForStar(Graph graph, int H_n)
        {
            for (int i = 0; i < graph.verticesCount; i++)
            {
                int blueVertices = 0;
                int redVertices = 0;
                List<(int, Color)> edges = graph.GetEdges(i);
                foreach (var edge in edges)
                {
                    if (edge.Item2 == Color.Blue) blueVertices++;
                    else redVertices++;
                }
                if (redVertices >= H_n-1 || blueVertices >= H_n-1) return true;
            }
            return false;
        }
        private static bool CheckForClique(Graph graph, int H_n)
        {
            return false;
        }
    }
}

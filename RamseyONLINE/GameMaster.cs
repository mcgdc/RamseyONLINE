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
                if (H_n == 3)
                    if (CheckForTriangle(graph, H_n)) return (true, Player.Builder);
                if (H_n == 4)
                    if (CheckForSquare(graph, H_n)) return (true, Player.Builder);
                if (H_n == 5)
                    if (CheckForPentagon(graph, H_n)) return (true, Player.Builder);
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
                if (redVertices >= H_n - 1 || blueVertices >= H_n - 1) return true;
            }
            return false;
        }
        private static bool CheckForTriangle(Graph graph, int H_n)
        {
            for (int i = 0; i < graph.verticesCount; i++)
            {
                for (int j = i + 1; j < graph.verticesCount; j++)
                {
                    for (int k = j + 1; k < graph.verticesCount; k++)
                    {
                        if (graph.GetEdges(i).Contains((j, Color.Blue)) && graph.GetEdges(i).Contains((k, Color.Blue)) && graph.GetEdges(j).Contains((k, Color.Blue))) return true;
                        if (graph.GetEdges(i).Contains((j, Color.Red)) && graph.GetEdges(i).Contains((k, Color.Red)) && graph.GetEdges(j).Contains((k, Color.Red))) return true;
                    }
                }
            }
            return false;
        }
        private static bool CheckForSquare(Graph graph, int H_n)
        {
            for (int i = 0; i < graph.verticesCount; i++)
            {
                for (int j = i + 1; j < graph.verticesCount; j++)
                {
                    for (int k = j + 1; k < graph.verticesCount; k++)
                    {
                        for (int l = k + 1; l < graph.verticesCount; l++)
                        {
                            if (graph.GetEdges(i).Contains((j, Color.Blue)) && graph.GetEdges(i).Contains((k, Color.Blue)) && graph.GetEdges(i).Contains((l, Color.Blue)) &&
                                graph.GetEdges(j).Contains((k, Color.Blue)) && graph.GetEdges(j).Contains((l, Color.Blue)) && graph.GetEdges(k).Contains((l, Color.Blue))) return true;
                            if (graph.GetEdges(i).Contains((j, Color.Red)) && graph.GetEdges(i).Contains((k, Color.Red)) && graph.GetEdges(i).Contains((l, Color.Red)) &&
                               graph.GetEdges(j).Contains((k, Color.Red)) && graph.GetEdges(j).Contains((l, Color.Red)) && graph.GetEdges(k).Contains((l, Color.Red))) return true;

                        }
                    }
                }
            }
            return false;
        }
        private static bool CheckForPentagon(Graph graph, int H_n)
        {
            for (int i = 0; i < graph.verticesCount; i++)
            {
                for (int j = i + 1; j < graph.verticesCount; j++)
                {
                    for (int k = j + 1; k < graph.verticesCount; k++)
                    {
                        for (int l = k + 1; l < graph.verticesCount; l++)
                        {
                            for (int m = l + 1; m < graph.verticesCount; m++)
                            {
                                if (graph.GetEdges(i).Contains((j, Color.Blue)) && graph.GetEdges(i).Contains((k, Color.Blue)) && graph.GetEdges(i).Contains((l, Color.Blue)) && graph.GetEdges(i).Contains((m, Color.Blue)) &&
                                graph.GetEdges(j).Contains((k, Color.Blue)) && graph.GetEdges(j).Contains((l, Color.Blue)) && graph.GetEdges(j).Contains((m, Color.Blue)) &&
                                graph.GetEdges(k).Contains((l, Color.Blue)) && graph.GetEdges(k).Contains((m, Color.Blue)) && graph.GetEdges(l).Contains((m, Color.Blue))) return true;
                                if (graph.GetEdges(i).Contains((j, Color.Red)) && graph.GetEdges(i).Contains((k, Color.Red)) && graph.GetEdges(i).Contains((l, Color.Red)) && graph.GetEdges(i).Contains((m, Color.Red)) &&
                                graph.GetEdges(j).Contains((k, Color.Red)) && graph.GetEdges(j).Contains((l, Color.Red)) && graph.GetEdges(j).Contains((m, Color.Red)) &&
                                graph.GetEdges(k).Contains((l, Color.Red)) && graph.GetEdges(k).Contains((m, Color.Red)) && graph.GetEdges(l).Contains((m, Color.Red))) return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

    }
}

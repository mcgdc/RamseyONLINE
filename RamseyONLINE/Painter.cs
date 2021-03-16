using System;
using System.Collections.Generic;
using System.Drawing;

namespace RamseyONLINE
{
    public static class Painter
    {

        public static Color PickColor(Graph graph, GraphKind H_kind, int H_n,int From,int To)
        {
            if (H_kind == GraphKind.clique)
            {
                Random r = new Random();
                return r.Next(0, 2) == 0 ? Color.Blue : Color.Red;
            }
            else
                return PickColor_star(graph,From,To);
        }
        private static Color PickColor_Clique(Graph graph, int H_n)
        {
            return Color.Red;
        }
        private static Color PickColor_star(Graph graph, int From,int To)
        {
            List<(int,Color)> fromVertexEdges = graph.GetEdges(From);
            List<(int, Color)> toVertexEdges = graph.GetEdges(To);
            int redFrom = fromVertexEdges.FindAll(edge => edge.Item2 == Color.Red).Count;
            int blueFrom = fromVertexEdges.FindAll(edge => edge.Item2 == Color.Blue).Count;
            int redTo = toVertexEdges.FindAll(edge => edge.Item2 == Color.Red).Count;
            int blueTo = toVertexEdges.FindAll(edge => edge.Item2 == Color.Blue).Count;
            return (Math.Max(redTo, redFrom) > Math.Max(blueTo, blueFrom)) ? Color.Blue : Color.Red;
        }
    }
}

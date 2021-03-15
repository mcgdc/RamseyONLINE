using System;
using System.Drawing;

namespace RamseyONLINE
{
    public static class Painter
    {

        public static Color PickColor(Graph graph, GraphKind H_kind, int H_n)
        {
            Random r = new Random();
            return r.Next(0, 2) == 0 ? Color.Blue : Color.Red;
        }
        private static Color PickColor_Clique(Graph graph, int H_n)
        {
            return Color.Red;
        }
        private static Color PickColor_star(Graph graph)
        {
            return Color.Red;
        }
    }
}

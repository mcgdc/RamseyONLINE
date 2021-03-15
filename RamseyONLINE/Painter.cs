using System;
using System.Drawing;

namespace RamseyONLINE
{
    public static class Painter
    {

        public static Color PickColor(Graph graph)
        {
            Random r = new Random();
            return r.Next(0, 2) == 0 ? Color.Blue : Color.Red;
        }

    }
}

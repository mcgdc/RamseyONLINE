using System;
using System.Drawing;

namespace RamseyONLINE
{
    public static class GraphDrawing
    {
        public static void DrawClique(Bitmap bitmap, int N)
        {
            double x_middle = bitmap.Width / 2;
            double y_middle = bitmap.Height / 2;
            double angle = 2 * Math.PI / (double)N;
            double radius = 3.0 / 4.0 * 0.5 * Math.Min(bitmap.Width, bitmap.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            (float x, float y)[] vertices = new (float, float)[N];
            for (int i = 0; i < N; i++)
            {
                vertices[i].x = (float)(x_middle + radius * Math.Cos(angle * i));
                vertices[i].y = (float)(y_middle + radius * Math.Sin(angle * i));
            }
            for (int i = 0; i < N; i++)
                for(int j=i;j<N;j++)
                    graphics.DrawLine(new Pen(new SolidBrush(Color.DarkGray),1.5f),vertices[i].x,vertices[i].y,vertices[j].x,vertices[j].y);
            foreach(var vertice in vertices)
                graphics.FillEllipse(new SolidBrush(Color.Maroon), vertice.x - 2, vertice.y - 2, 4, 4);

            graphics.Dispose();
        }
        public static void DrawIsolatedVerices(Bitmap bitmap, int N)
        {
            double x_middle = bitmap.Width / 2;
            double y_middle = bitmap.Height / 2;
            double angle = 2 * Math.PI / (double)N;
            double radius = 3.0 / 4.0 * 0.5 * Math.Min(bitmap.Width, bitmap.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            (float x, float y)[] vertices = new (float, float)[N];
            for (int i = 0; i < N; i++)
            {
                vertices[i].x = (float)(x_middle + radius * Math.Cos(angle * i));
                vertices[i].y = (float)(y_middle + radius * Math.Sin(angle * i));
            }
            foreach (var vertice in vertices)
                graphics.FillEllipse(new SolidBrush(Color.Maroon), vertice.x - 2, vertice.y - 2, 4, 4);

            graphics.Dispose();
        }
        public static void DrawStar(Bitmap bitmap, int N)
        {
            float x_middle = bitmap.Width / 2;
            float y_middle = bitmap.Height / 2;
            double angle = 2 * Math.PI / (double)(N-1);
            double radius = 3.0 / 4.0 * 0.5 * Math.Min(bitmap.Width, bitmap.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            (float x, float y)[] vertices = new (float, float)[N-1];
            for (int i = 0; i < N-1; i++)
            {
                vertices[i].x = (float)(x_middle + radius * Math.Cos(angle * i));
                vertices[i].y = (float)(y_middle + radius * Math.Sin(angle * i));
                graphics.DrawLine(new Pen(new SolidBrush(Color.DarkGray)), x_middle, y_middle, vertices[i].x, vertices[i].y);
                graphics.FillEllipse(new SolidBrush(Color.Maroon), vertices[i].x - 2, vertices[i].y - 2, 4, 4);
            }
            graphics.FillEllipse(new SolidBrush(Color.Maroon), x_middle - 2, y_middle - 2, 4, 4);

            graphics.Dispose();
        }
    }
}

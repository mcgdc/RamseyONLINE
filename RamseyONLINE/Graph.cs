using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamseyONLINE
{
    public class Graph
    {
        List<List<(int, Color)>> adjacencyList;
        (int x,int y)[] vertices;
        Graphics graphics;
        public Graph(int n)
        {
            Bitmap bitmap = new Bitmap(1028,633); //POPRAWIC!!!

            graphics = Graphics.FromImage(bitmap); // plus zablokowanie zmiany rozmiaru?
            double x_middle = bitmap.Width / 2;
            double y_middle = bitmap.Height / 2;
            double angle = 2 * Math.PI / (double)n;
            double radius = 3.0 / 4.0 * 0.5 * Math.Min(bitmap.Width, bitmap.Height);
            for (int i = 0; i < n; i++)
            {
                adjacencyList[i] = new List<(int,Color)>();
                vertices[i].x = (int)(x_middle + radius * Math.Cos(angle * i));
                vertices[i].y = (int)(y_middle + radius * Math.Sin(angle * i));
            }
        }
        public void AddEdge(int u, int v,Color color)
        {
            //Dodać sprawdzanie czy taka już nie istnieje?
            //-przy rysowaniu
            //-nie dodaje sie krawedz
            adjacencyList[u].Add((v, color));
            adjacencyList[v].Add((u, color));
        }
        public void DrawGraph()
        {

            for (int i = 0; i < adjacencyList.Count; i++)
            {
                for (int j = 0; j < adjacencyList[i].Count; j++)
                {
                    //można dodać ifa żeby rysować tylko raz
                        graphics.DrawLine(new Pen(new SolidBrush(adjacencyList[i][j].Item2)), vertices[j].x, vertices[j].y, vertices[i].x, vertices[i].y);
                }
            }
            for (int i = 0; i < vertices.Length; i++)
                graphics.FillEllipse(new SolidBrush(Color.Maroon), vertices[i].x - 2, vertices[i].y - 2, 4, 4);

        }
        public int IsOverVertex(int x, int y)
        {
            int precision = 10;
            for (int i = 0; i < vertices.Length; i++)
            {
                if (Math.Abs(vertices[i].x - x) < precision && Math.Abs(vertices[i].y - y) < precision) return i;
            }
            return -1;
        }

        //Do algorytmu przyda się jakaś metoda udostepniająca krawędzie dla danego wierzchołka

    }
}

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
        public Graph(int n,int bitmapWidth,int bitmapHeight)
        {
            vertices = new (int x, int y)[n];
            adjacencyList = new List<List<(int, Color)>>();
            for (int i = 0; i < n; i++)
                adjacencyList.Add(new List<(int,Color)>());
            double x_middle = bitmapWidth / 2;
            double y_middle = bitmapHeight / 2;
            double angle = 2 * Math.PI / (double)n;
            double radius = 3.0 / 4.0 * 0.5 * Math.Min(bitmapWidth, bitmapHeight);
            for (int i = 0; i < n; i++)
            {
                adjacencyList[i] = new List<(int,Color)>();
                vertices[i].x = (int)(x_middle + radius * Math.Cos(angle * i));
                vertices[i].y = (int)(y_middle + radius * Math.Sin(angle * i));
            }
        }
        public void AddEdge(int u, int v,Color color)
        {
            adjacencyList[u].Add((v, color));
            adjacencyList[v].Add((u, color));
        }
        public void DrawGraph(Graphics graphics)
        {
            int vertexSize = 6;
            for (int i = 0; i < adjacencyList.Count; i++)
            {
                for (int j = 0; j < adjacencyList[i].Count; j++)
                {
                        graphics.DrawLine(new Pen(new SolidBrush(adjacencyList[i][j].Item2)), vertices[i].x, vertices[i].y, vertices[adjacencyList[i][j].Item1].x, vertices[adjacencyList[i][j].Item1].y);
                }
            }
            for (int i = 0; i < vertices.Length; i++)
                graphics.FillEllipse(new SolidBrush(Color.Maroon), vertices[i].x - vertexSize/2, vertices[i].y - vertexSize/2, vertexSize, vertexSize);

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
        public (int,int) GetVertexPosition(int n)
        {
            return (vertices[n].x, vertices[n].y);
        }
        public bool ContainsEdge(int vertex1,int vertex2)
        {
            if (adjacencyList[vertex1].Contains((vertex2, Color.Red)) || adjacencyList[vertex1].Contains((vertex2, Color.Blue)))return true;
            return false;
        }

        //Do algorytmu przyda się jakaś metoda udostepniająca krawędzie dla danego wierzchołka

    }
}

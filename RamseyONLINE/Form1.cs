using System.Drawing;
using System.Windows.Forms;

namespace RamseyONLINE
{
    public partial class Form1 : Form
    {
        public GraphKind kindOfGraph { get; set; }
        public int numberOfIsolatedvertices { get; set; }
        public int numberOfvertices_H { get; set; }
        public Graph graph { get; set; }
        public bool drawingEdge { get; set; }
        public (int, int) startPointPosition { get; set; }
        public int startVertex { get; set; }
        public Form1()
        {
            InitializeComponent();
            StartForm startForm = new StartForm() { Owner = this };
            startForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            startForm.StartPosition = FormStartPosition.CenterParent;
            startForm.ShowDialog(this);
            pictureBox_H.Image = new Bitmap(pictureBox_H.Width, pictureBox_H.Height);
            pictureBox_game.Image = new Bitmap(pictureBox_game.Width, pictureBox_game.Height);

            if (kindOfGraph == GraphKind.clique)
                GraphDrawing.DrawClique((Bitmap)pictureBox_H.Image, numberOfvertices_H);
            else GraphDrawing.DrawStar((Bitmap)pictureBox_H.Image, numberOfvertices_H);

            graph = new Graph(numberOfIsolatedvertices, pictureBox_game.Width, pictureBox_game.Height);
            graph.DrawGraph(Graphics.FromImage(pictureBox_game.Image));
            pictureBox_H.Refresh();
            pictureBox_game.Refresh();
        }

        private void pictureBox_game_MouseDown(object sender, MouseEventArgs e)
        {
            int n = graph.IsOverVertex(e.X, e.Y);
            if (n > -1)
            {
                drawingEdge = true;
                startVertex = n;
                startPointPosition = graph.GetVertexPosition(n);
            }
        }

        private void pictureBox_game_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingEdge)
            {
                Graphics graphics = Graphics.FromImage(pictureBox_game.Image);
                graphics.Clear(Color.White);
                graph.DrawGraph(graphics);
                graphics.DrawLine(new Pen(new SolidBrush(Color.DarkGray), 2f), startPointPosition.Item1, startPointPosition.Item2, e.X, e.Y);
                pictureBox_game.Refresh();
            }
        }

        private void pictureBox_game_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawingEdge)
            {
                drawingEdge = false;
                int n = graph.IsOverVertex(e.X, e.Y);
                if (n > -1)
                {
                    if (!graph.ContainsEdge(startVertex, n))
                        graph.AddEdge(startVertex, n, Painter.PickColor(graph));
                }
                Graphics graphics = Graphics.FromImage(pictureBox_game.Image);
                graphics.Clear(Color.White);
                graph.DrawGraph(graphics);
                pictureBox_game.Refresh();
            }
        }
    }
}

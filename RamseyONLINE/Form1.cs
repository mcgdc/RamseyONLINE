using System.Drawing;
using System.Windows.Forms;

namespace RamseyONLINE
{
    public partial class Form1 : Form
    {
        public GraphKind kindOfGraph { get; set; }
        public int numberOfIsolatedvertices { get; set; }
        public int numberOfvertices_H { get; set; }

        private Graph graph;
        private bool drawingEdge;
        private (int, int) startPointPosition;
        private int startVertex;
        private int numberOfEdges = 0;

        public bool PlayAgain { get; set; }
        public Form1()
        {
            InitializeComponent();
           
            pictureBox_H.Image = new Bitmap(pictureBox_H.Width, pictureBox_H.Height);
            pictureBox_game.Image = new Bitmap(pictureBox_game.Width, pictureBox_game.Height);
            SetUpGame();
        }

        private void SetUpGame()
        {
            StartForm startForm = new StartForm() { Owner = this };
            startForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            startForm.StartPosition = FormStartPosition.CenterParent;
            startForm.ShowDialog(this);
            if (kindOfGraph == GraphKind.clique)
                GraphDrawing.DrawClique((Bitmap)pictureBox_H.Image, numberOfvertices_H);
            else GraphDrawing.DrawStar((Bitmap)pictureBox_H.Image, numberOfvertices_H);

            graph = new Graph(numberOfIsolatedvertices, pictureBox_game.Width, pictureBox_game.Height);
            graph.DrawGraph(Graphics.FromImage(pictureBox_game.Image));
            pictureBox_H.Refresh();
            pictureBox_game.Refresh();
            numberOfEdges = 0;
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
                Graphics graphics = Graphics.FromImage(pictureBox_game.Image);
                drawingEdge = false;
                int n = graph.IsOverVertex(e.X, e.Y);
                if (n > -1)
                {
                    if (!graph.ContainsEdge(startVertex, n))
                    {
                        graph.AddEdge(startVertex, n, Painter.PickColor(graph, kindOfGraph, numberOfvertices_H));
                        numberOfEdges++;
                        graphics.Clear(Color.White);
                        graph.DrawGraph(graphics);
                        pictureBox_game.Refresh();
                    }
                    var result = GameMaster.CheckIfEnd(graph, kindOfGraph, numberOfvertices_H, numberOfIsolatedvertices, numberOfEdges);
                    if (result.Item1)
                    {
                        EndGame(result.Item2);
                    }
                }
                graphics.Clear(Color.White);
                graph.DrawGraph(graphics);
                pictureBox_game.Refresh();
            }
        }

        private void EndGame(Player winner)
        {
            ShowResults(winner);

            if (PlayAgain)
                SetUpNewGame();
            else this.Close();
        }
        private void ShowResults(Player winner)
        {
            ResultForm resultForm = new ResultForm(winner==Player.Builder) { Owner = this };
            resultForm.ShowDialog(this);
        }
        private void SetUpNewGame()
        {
            pictureBox_game.Image = new Bitmap(pictureBox_game.Width, pictureBox_game.Height);
            pictureBox_H.Image = new Bitmap(pictureBox_H.Width, pictureBox_H.Height);
            pictureBox_H.Refresh();
            pictureBox_game.Refresh();
            SetUpGame();
        }
    }
}

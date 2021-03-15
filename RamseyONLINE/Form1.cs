using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamseyONLINE
{
    public partial class Form1 : Form
    {
        public GraphKind kindOfGraph { get; set; }
        public int numberOfIsolatedvertices { get; set; }
        public int numberOfvertices_H { get; set; }
        public Graph graph;
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

            //GraphDrawing.DrawIsolatedVerices((Bitmap)pictureBox_game.Image, numberOfIsolatedvertices,10);
            graph = new Graph(numberOfIsolatedvertices, pictureBox_game.Width, pictureBox_game.Height);
            //graph.AddEdge(0, 1, Color.Red);
            graph.DrawGraph(Graphics.FromImage(pictureBox_game.Image));
            pictureBox_H.Refresh();
            pictureBox_game.Refresh();
        }

        private void pictureBox_game_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox_game_MouseDown(object sender, MouseEventArgs e)
        {
            if(graph.IsOverVertex(e.X,e.Y)>-1)
            {

            }
        }
    }
}

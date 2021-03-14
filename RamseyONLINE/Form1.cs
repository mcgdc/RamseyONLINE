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

            GraphDrawing.DrawIsolatedVerices((Bitmap)pictureBox_game.Image, numberOfIsolatedvertices,10);
            pictureBox_game.Refresh();
            pictureBox_H.Refresh();
        }
    }
}

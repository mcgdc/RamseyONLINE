using System;
using System.Drawing;
using System.Windows.Forms;

namespace RamseyONLINE
{
    public partial class StartForm : Form
    {
        private bool clique = true;
        public StartForm()
        {
            InitializeComponent();
            pictureBox_N.Image = new Bitmap(pictureBox_N.Width, pictureBox_N.Height);
            pictureBox_clique.Image = new Bitmap(pictureBox_clique.Width, pictureBox_clique.Height);
            pictureBox_star.Image = new Bitmap(pictureBox_star.Width, pictureBox_star.Height);
            pictureBox_preview.Image = new Bitmap(pictureBox_preview.Width, pictureBox_preview.Height);
            panel_clique.BackColor = Color.Maroon;

            GraphDrawing.DrawClique((Bitmap)pictureBox_clique.Image, 5);
            GraphDrawing.DrawStar((Bitmap)pictureBox_star.Image, 8);

            comboBox_h.Items.AddRange(new object[] { "3" });
            comboBox_h.SelectedIndex = 0;
            comboBox_N.Items.AddRange(new object[] { "4", "5", "6", "7", "8" });
            comboBox_N.SelectedIndex = 0;

            DrawPreview();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_N_SelectedIndexChanged(object sender, EventArgs e)
        {
            int N = int.Parse((string)comboBox_N.SelectedItem);
            comboBox_h.Items.Clear();
            for (int i = 3; i < N; i++)
            {
                comboBox_h.Items.Add(i.ToString());
            }
            comboBox_h.SelectedIndex = 0;
            pictureBox_N.Image = new Bitmap(pictureBox_N.Width, pictureBox_N.Height);
            GraphDrawing.DrawIsolatedVerices((Bitmap)pictureBox_N.Image, N);
            pictureBox_N.Refresh();
        }

        private void comboBox_h_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawPreview();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var owner = (Form1)this.Owner;
            owner.kindOfGraph = clique ? GraphKind.clique : GraphKind.star;
            owner.numberOfvertices_H = int.Parse((string)comboBox_h.SelectedItem);
            owner.numberOfIsolatedvertices = int.Parse((string)comboBox_N.SelectedItem);
        }

        private void pictureBox_clique_Click(object sender, EventArgs e)
        {
            if (!clique)
            {
                clique = true;
                panel_clique.BackColor = Color.Maroon;
                panel_star.BackColor = Color.White;
            }
            DrawPreview();
        }
        private void pictureBox_star_Click(object sender, EventArgs e)
        {
            if (clique)
            {
                clique = false;
                panel_clique.BackColor = Color.White;
                panel_star.BackColor = Color.Maroon;
            }
            DrawPreview();
        }
        private void DrawPreview()
        {
            pictureBox_preview.Image = new Bitmap(pictureBox_preview.Width, pictureBox_preview.Height);
            if(clique)
                GraphDrawing.DrawClique((Bitmap)pictureBox_preview.Image, int.Parse((string)comboBox_h.SelectedItem));
            else
                GraphDrawing.DrawStar((Bitmap)pictureBox_preview.Image, int.Parse((string)comboBox_h.SelectedItem));
            pictureBox_preview.Refresh();
        }
    }
}

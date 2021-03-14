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
    public partial class StartForm : Form
    {
        private bool clique = true;
        public StartForm()
        {
            InitializeComponent();
            comboBox_N.Items.AddRange(new object[] { "4","5","6","7","8","9","10","11","12"});
            comboBox_N.SelectedIndex = 0;
            comboBox_h.Items.AddRange(new object[] { "3"});
            comboBox_h.SelectedIndex = 0;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            var owner = (Form1)this.Owner;
            owner.kindOfGraph = clique ? GraphKind.clique : GraphKind.star;
            owner.numberOfvertices_H = int.Parse((string)comboBox_h.SelectedItem);
            owner.numberOfIsolatedvertices = int.Parse((string)comboBox_N.SelectedItem);
        }

        private void comboBox_N_SelectedIndexChanged(object sender, EventArgs e)
        {
            int N = int.Parse((string)comboBox_N.SelectedItem);
            comboBox_h.Items.Clear();
            for(int i=3;i<N;i++)
            {
                comboBox_h.Items.Add(i.ToString());
            }
            comboBox_h.SelectedIndex = 0;
        }

        private void comboBox_h_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_clique_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

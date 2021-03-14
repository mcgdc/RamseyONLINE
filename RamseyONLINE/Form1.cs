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
        }
    }
}

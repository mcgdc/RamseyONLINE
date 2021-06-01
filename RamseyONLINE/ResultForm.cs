using System;
using System.Drawing;
using System.Windows.Forms;

namespace RamseyONLINE
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        public ResultForm(bool user_win)
        {
            InitializeComponent();
            if (user_win)
            {
                label_result.Text = "Congratulations! :)";
                label_result.ForeColor = Color.Green;
            }
            else
            {
                label_result.Text = "Sorry :(";
                label_result.ForeColor = Color.Red;
            }

        }

        private void button_again_Click(object sender, EventArgs e)
        {
            ((Form1)this.Owner).PlayAgain = true;
            this.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            ((Form1)this.Owner).PlayAgain = false;
            this.Close();
        }
    }
}

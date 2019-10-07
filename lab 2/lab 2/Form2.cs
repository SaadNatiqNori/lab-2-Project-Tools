using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oldFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Welcome To the Form 2".ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripLabel1.Text = string.Empty;
            toolStripButton1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

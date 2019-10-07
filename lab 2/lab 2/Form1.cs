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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void examle5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //insert to label in the left
            toolStripLabel1.Text = toolStripTextBox1.Text;
            //Insert item to MenuStrip
            menuStrip1.Items.Add(toolStripTextBox1.Text);
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "I am a label";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "I am a TextBox";
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            checkBox1.Text = "I am a CheckBox";
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.Text = "Hover Me";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "Hover Me";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Hover Me";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            textBox1.Text = string.Empty;
            checkBox1.Text = string.Empty;
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //copy code
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox txtBox = this.ActiveControl as TextBox;
            if (txtBox.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, txtBox.SelectedText);
        }
        //cut code
        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox txtBox = this.ActiveControl as TextBox;
            if (txtBox.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, txtBox.SelectedText);
            txtBox.SelectedText = string.Empty;
        }
        //paste code
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int position = ((TextBox)this.ActiveControl).SelectionStart;
            this.ActiveControl.Text = this.ActiveControl.Text.Insert(position, Clipboard.GetText());
        }
    }
}

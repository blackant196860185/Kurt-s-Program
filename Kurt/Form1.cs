using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Kurts Program");
            MessageBox.Show("This is Version 11.0.0.0");
            MessageBox.Show("© 2019 Kurt Devilbiss All Rights Reserved");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                progressBar1.Value += 100;
                MessageBox.Show("You checked the Random Secret Check Box now you are the Developer of this program");
            }
            if (checkBox1.Checked == false)
            {
                progressBar1.Value -= 100;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                progressBar2.Value += 100;
                label1.Text = ("change %100");
            }
            if (checkBox2.Checked == false)
            {
                progressBar2.Value -= 100;
                label1.Text = ("change %0");
            }
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

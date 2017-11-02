using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool trl = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed the button");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed the label");
        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("You drageed the label");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            int a = e.X;
            int b = e.Y;
            if (trl == true)
            {
                label1.Text = a.ToString() + "  " + b.ToString();
            }
            }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            trl = !trl;
        }
    }
}

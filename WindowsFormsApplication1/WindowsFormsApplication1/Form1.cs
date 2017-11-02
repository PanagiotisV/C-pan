using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[,] pinakas = new String[5,2]{
            {"panagiotis","123"},{"panpan","1234"},{"maria","kapsali" },{"ion","cho" },{"pun","pun" }
        };

       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int j = 0;
            bool y = true;
            for (int i = 0; i < 5; i++)
			{
               if (textBox1.Text == pinakas[i, j] & textBox2.Text == pinakas[i, j+1])
                        {
                            Form2 a = new Form2(pinakas[i,j]);
                            a.Show();
                            y = false;
                
                        }
             

               
            }

            if (y == true)
            {
                Form3 b = new Form3();
                b.Show();
                textBox1.Clear();
                textBox2.Clear();
            }
            
             
            
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

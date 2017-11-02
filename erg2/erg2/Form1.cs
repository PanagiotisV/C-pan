using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erg2
{
    
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                counter = counter + 1;
                string s = " ";
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                if (comboBox1.Text == "Add +")
                {
                    float i = a + b;
                    s = i.ToString();
                 
                }
                if (comboBox1.Text == "Substract -")
                {
                    float i = a - b;
                    s = i.ToString();
                    
                }
                if (comboBox1.Text == "Multiplicate *")
                {
                    float i = a * b;
                    s = i.ToString();
                  
                }
                if (comboBox1.Text == "Divide /")
                {

                    if (b != 0)
                    {
                        float i = a / b;
                        s = i.ToString();
                    }
                    else
                    {
                        s = "Infinite";
                    }
                }
                if (comboBox1.Text == "")
                {
                    s = "Choose a method";
                }
                textBox3.Text = s;
                textBox3.Visible = true;
                if (counter == 10)
                {
                    label1.Visible = true;
                    label1.Text = "Don't you think 10 times are enough?";
                }
                if (counter == 15)
                {
                    label1.Visible = false;
                }
                if (counter == 20)
                {
                    label2.Visible = true;
                    label2.Text = "Well 20 are too much...";
                }
                if (counter == 25)
                {
                    label2.Visible = false;
                }
                if (counter == 40)
                {
                    label1.Visible = true;
                    label2.Text = "Stop pressing ";
                    label2.Visible = true;
                    label1.Text = "the button!!";
                }
            }
            catch (Exception) {
                textBox3.Text = "Use only numbers";
                textBox3.Visible = true;
            }
        }


           
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

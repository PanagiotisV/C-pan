using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        float x1, y1, x2, y2;
        bool flag = false;
        bool trl = false;
        int i = 0;
        int s = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            p = new Pen(Color.Black);
           
            p.Width = 5;

            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (comboBox2.Text == "Free draw")
            {
                x1 = e.X;
                y1 = e.Y;
                flag = true;
            }
            else
            {
                x1 = e.X;
                y1 = e.Y;
                
            }
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (comboBox2.Text == "Free draw")
            {
                if (flag)
                {
                    g.DrawLine(p, x1, y1, e.X, e.Y);
                    x1 = e.X;
                    y1 = e.Y;
                }

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            float z = float.Parse(comboBox3.Text);
            p.Width = z;
            label5.Text = comboBox3.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox2.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            s = 1;
         
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s == 1)
            {
                if (i == 0)
                {
                    g.DrawLine(p, 150, 150, 100, 150);
                }
                if (i == 1)
                {
                    g.DrawLine(p, 150, 150, 150, 100);
                }
                else if (i == 2)
                {
                    g.DrawLine(p, 150, 150, 200, 150);
                }
                else if (i == 3)
                {
                    g.DrawLine(p, 150, 150, 150, 200);
                }
                else if (i == 4)
                {
                    g.DrawLine(p, 110, 110, 150, 150);
                }
                else if (i == 5)
                {
                    g.DrawLine(p, 190, 190, 150, 150);
                }
                else if (i == 6)
                {
                    g.DrawLine(p, 150, 150, 110, 190);
                }
                else if (i == 7)
                {
                    g.DrawLine(p, 150, 150, 190, 110);

                }
                else if (i == 8)
                {
                    g.DrawLine(p, 125, 125, 106, 125);
                }
                else if (i == 9)
                {
                    g.DrawLine(p, 125, 125, 125, 106);
                }
                else if (i == 10)
                {
                    g.DrawLine(p, 115, 150, 108, 135);

                }
                else if (i == 11)
                {
                    g.DrawLine(p, 115, 150, 108, 165);

                }
                else if (i == 12)
                {
                    g.DrawLine(p, 125, 125, 106, 125);

                }
                else if (i == 13)
                {
                    g.DrawLine(p, 125, 175, 106, 175);

                }
                else if (i == 14)
                {
                    g.DrawLine(p, 125, 175, 125, 194);

                }
                else if (i == 15)
                {
                    g.DrawLine(p, 185, 150, 192, 165);

                }
                else if (i == 16)
                {
                    g.DrawLine(p, 185, 150, 192, 135);

                }
                else if (i == 17)
                {
                    g.DrawLine(p, 175, 125, 194, 125);

                }
                else if (i == 18)
                {
                    g.DrawLine(p, 175, 125, 175, 106);

                }
                else if (i == 19)
                {
                    g.DrawLine(p, 175, 175, 194, 175);

                }
                else if (i == 20)
                {
                    g.DrawLine(p, 175, 175, 175, 194);

                }
                else if (i == 21)
                {
                    g.DrawLine(p, 150, 119, 137, 103);
                }
                else if (i == 22)
                {
                    g.DrawLine(p, 150, 119, 163, 103);

                }
                else if (i == 23)
                {
                    g.DrawLine(p, 150, 181, 137, 197);

                }
                else if (i == 24)
                {
                    g.DrawLine(p, 150, 181, 163, 197);

                }
                else if (i == 25)
                {
                    timer1.Enabled = false;
                    i = -1;
                }
            }
            if (s == 2)

            {
                if (i == 0)
                {
                    g.DrawEllipse(p, 150, 350, 200, 200);
                }
                else if (i == 1)
                {
                    g.DrawEllipse(p, 175, 200, 150, 150);
                }
                else if (i == 2)
                {
                    g.DrawEllipse(p, 200, 100, 100, 100);
                }
                else if (i == 3)
                {
                    g.DrawLine(p, 175, 100, 325, 100);
                }
                else if ( i == 4)
                {
                    g.DrawLine(p, 220, 100, 220, 50);
                }
                else if (i == 5)
                {
                    g.DrawLine(p, 220, 50, 290, 50);
                }
                else if (i == 6)
                {
                    g.DrawLine(p, 290, 50, 290, 100);
                }
                else if (i == 7)
                {
                    g.DrawEllipse(p, 237, 133, 12, 12);
                        
                }
                else if (i == 8)
                {
                    g.DrawEllipse(p, 260, 133, 12, 12);
                }
                else if (i == 9)
                {
                    g.DrawLine(p, 250, 145, 270, 155);
                }
                else if (i == 10)
                {
                    g.DrawLine(p, 270, 155, 250, 165);

                }
                else if (i == 11)
                {
                    g.DrawLine(p, 225, 175, 275, 175);
                }
                else if (i == 12)
                {
                    g.DrawLine(p, 184, 241, 126, 311);
                }
                else if (i == 13)
                {
                    g.DrawLine(p, 148, 283, 119, 290);
                }
                else if (i == 14)
                {
                    g.DrawLine(p, 138, 298, 150, 308);
                }
                else if (i == 15)
                {
                    g.DrawLine(p, 321, 252, 367, 297);
                }
                else if (i == 16)
                {
                    g.DrawLine(p, 346, 277, 371, 287);
                }
                else if (i == 17)
                {
                    timer1.Enabled = false;
                    i = -1;
                }
            }
            if (s == 3)
            {
                if (i == 0) {
                    g.DrawLine(p, 239, 206, 162, 284);
                }
                else if (i == 1)
                {
                    g.DrawLine(p, 162, 284, 226, 286);
                }
                else if (i == 2)
                {
                    g.DrawLine(p, 226, 286, 117, 378);
                }
                else if (i == 3)
                {
                    g.DrawLine(p, 117, 378, 205, 376);
                }
                else if (i == 4)
                {
                    g.DrawLine(p, 205, 376, 62, 486);
                }
                else if (i == 5)
                {
                    g.DrawLine(p, 62, 486, 440, 486);
                }
                else if (i == 6)
                {
                    g.DrawLine(p, 440, 486, 260, 371);
                }
                else if (i == 7)
                {
                    g.DrawLine(p, 260, 371, 370, 360);
                }
                else if (i == 8)
                {
                    g.DrawLine(p, 370, 360, 273, 284);

                }
                else if (i == 9)
                {
                    g.DrawLine(p, 273, 284, 318, 277);
                }
                else if (i == 10)
                {
                    g.DrawLine(p, 318, 277, 239, 206);
                }
                else if (i == 11)
                {
                    g.DrawLine(p, 205, 482, 205, 552);

                }
                else if (i == 12)
                {
                    g.DrawLine(p, 205, 552, 277, 552);
                }
                else if (i == 13)
                {
                    g.DrawLine(p, 277, 552, 277, 482);
                }
                else if (i == 14)
                {
                    timer1.Enabled = false;
                    i = -1;
                }
            }
            i = i + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s = 2;
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s = 3;
            timer1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Black")
            {
                p.Color = Color.Black;
            }
           else if (comboBox1.Text == "Red")
            {
                p .Color = Color.Red;
            }
            else if (comboBox1.Text == "Blue")
            {
                p.Color = Color.Blue;
            }
            else if (comboBox1.Text == "Green")
            {
                p.Color = Color.Green;
            }
            else if (comboBox1.Text == "Yellow")
            {
                p.Color = Color.Yellow;
            }
            else if (comboBox1.Text == "Cyan")
            {
                p.Color = Color.Cyan;
            }
            else if (comboBox1.Text == "Eraser")
            {
                p.Color = Color.White;
            }
            label4.Text = comboBox1.Text;
           
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            trl = !trl;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            float w = x2 - x1;
            float h = y2 - y1;
            if (comboBox2.Text == "Line")
            {
                g.DrawLine(p, x1, y1, x2, y2);
            }
            else if (comboBox2.Text == "Free draw")
            {
                flag = false;
            }
            else if (comboBox2.Text == "Rectangular")
            {
                g.DrawRectangle(p, x1, y1, w, h);
            }
            else if (comboBox2.Text == "Ellipse")
            {
                g.DrawEllipse(p, x1, y1, w, h);
            }
            else if(comboBox2.Text == "Circle")
            {
                g.DrawEllipse(p, x1, y1, w, h);
            
            }
        }
    }
}

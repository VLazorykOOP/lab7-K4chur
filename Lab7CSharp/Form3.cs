using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab7CSharp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Square temp = new Square(textBox1);
                
                int cl = 1;
                if (radioButton5.Checked)
                {
                    cl = 4;
                } else if (radioButton6.Checked)
                {
                    cl = 3;
                } else if (radioButton7.Checked)
                {
                    cl = 2;
                } else if (radioButton8.Checked)
                {
                    cl = 1;
                }
                
                temp.Print(pictureBox1,cl);
                SquareX = temp.x;
                SquareY = temp.y;
                SideSq = temp.side;
                cls = cl;
            } else if (radioButton2.Checked)
            {
                Rectangle temp = new Rectangle(textBox2, textBox3);
                int cl = 1;
                if (radioButton5.Checked)
                {
                    cl = 4;
                }
                else if (radioButton6.Checked)
                {
                    cl = 3;
                }
                else if (radioButton7.Checked)
                {
                    cl = 2;
                }
                else if (radioButton8.Checked)
                {
                    cl = 1;
                }
                
                temp.Print(pictureBox1, cl);
                RecX = temp.x;
                RecY = temp.y;
                SideReca = temp.sidea;
                SideRecb = temp.sideb;
                clr = cl;
            } else if (radioButton3.Checked)
            {
                Triangle temp = new Triangle(textBox4);
                int cl = 1;
                if (radioButton5.Checked)
                {
                    cl = 4;
                }
                else if (radioButton6.Checked)
                {
                    cl = 3;
                }
                else if (radioButton7.Checked)
                {
                    cl = 2;
                }
                else if (radioButton8.Checked)
                {
                    cl = 1;
                }
                

                temp.Print(pictureBox1, cl);
                TriangleX = temp.x;
                TriangleY = temp.y;
                SideTr = temp.side;
                clt = cl;
            } else if (radioButton4.Checked)
            {
                Circle temp = new Circle(textBox5);
                int cl = 1;
                if (radioButton5.Checked)
                {
                    cl = 4;
                }
                else if (radioButton6.Checked)
                {
                    cl = 3;
                }
                else if (radioButton7.Checked)
                {
                    cl = 2;
                }
                else if (radioButton8.Checked)
                {
                    cl = 1;
                }
                
                temp.Print(pictureBox1, cl);
                CircleX = temp.x;
                CircleY = temp.y;
                clc = cl;
                RadiusC = temp.radius;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Square temp = new Square(SideSq, SquareX, SquareY);
                temp.RandomMove(pictureBox1, cls);
                SquareX = temp.x;
                SquareY = temp.y;

            } else if (radioButton2.Checked)
            {
                Rectangle temp = new Rectangle(SideReca, SideRecb, RecX, RecY);
                temp.RandomMove(pictureBox1, clr);
                RecX = temp.x;
                RecY = temp.y;
            } else if (radioButton3.Checked)
            {
                Triangle temp = new Triangle(SideTr, TriangleX, TriangleY);
                temp.RandomMove(pictureBox1, clt);
                TriangleX = temp.x;
                TriangleY = temp.y;
            } else if (radioButton4.Checked)
            {
                Circle temp = new Circle(RadiusC, CircleX, CircleY);
                temp.RandomMove(pictureBox1, clc);
                CircleX = temp.x;
                CircleY = temp.y;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Square temp = new Square(SideSq, SquareX, SquareY);
                temp.Move(pictureBox1, cls,1);
                SquareX = temp.x;
                SquareY = temp.y;

            }
            else if (radioButton2.Checked)
            {
                Rectangle temp = new Rectangle(SideReca, SideRecb, RecX, RecY);
                temp.Move(pictureBox1, clr,1);
                RecX = temp.x;
                RecY = temp.y;
            }
            else if (radioButton3.Checked)
            {
                Triangle temp = new Triangle(SideTr, TriangleX, TriangleY);
                temp.Move(pictureBox1, clt,1);
                TriangleX = temp.x;
                TriangleY = temp.y;
            }
            else if (radioButton4.Checked)
            {
                Circle temp = new Circle(RadiusC, CircleX, CircleY);
                temp.Move(pictureBox1, clc,1);
                CircleX = temp.x;
                CircleY = temp.y;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Square temp = new Square(SideSq, SquareX, SquareY);
                temp.Move(pictureBox1, cls, 2);
                SquareX = temp.x;
                SquareY = temp.y;

            }
            else if (radioButton2.Checked)
            {
                Rectangle temp = new Rectangle(SideReca, SideRecb, RecX, RecY);
                temp.Move(pictureBox1, clr, 2);
                RecX = temp.x;
                RecY = temp.y;
            }
            else if (radioButton3.Checked)
            {
                Triangle temp = new Triangle(SideTr, TriangleX, TriangleY);
                temp.Move(pictureBox1, clt, 2);
                TriangleX = temp.x;
                TriangleY = temp.y;
            }
            else if (radioButton4.Checked)
            {
                Circle temp = new Circle(RadiusC, CircleX, CircleY);
                temp.Move(pictureBox1, clc, 2);
                CircleX = temp.x;
                CircleY = temp.y;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Square temp = new Square(SideSq, SquareX, SquareY);
                temp.Move(pictureBox1, cls, 3);
                SquareX = temp.x;
                SquareY = temp.y;

            }
            else if (radioButton2.Checked)
            {
                Rectangle temp = new Rectangle(SideReca, SideRecb, RecX, RecY);
                temp.Move(pictureBox1, clr, 3);
                RecX = temp.x;
                RecY = temp.y;
            }
            else if (radioButton3.Checked)
            {
                Triangle temp = new Triangle(SideTr, TriangleX, TriangleY);
                temp.Move(pictureBox1, clt, 3);
                TriangleX = temp.x;
                TriangleY = temp.y;
            }
            else if (radioButton4.Checked)
            {
                Circle temp = new Circle(RadiusC, CircleX, CircleY);
                temp.Move(pictureBox1, clc, 3);
                CircleX = temp.x;
                CircleY = temp.y;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Square temp = new Square(SideSq, SquareX, SquareY);
                temp.Move(pictureBox1, cls, 4);
                SquareX = temp.x;
                SquareY = temp.y;

            }
            else if (radioButton2.Checked)
            {
                Rectangle temp = new Rectangle(SideReca, SideRecb, RecX, RecY);
                temp.Move(pictureBox1, clr, 4);
                RecX = temp.x;
                RecY = temp.y;
            }
            else if (radioButton3.Checked)
            {
                Triangle temp = new Triangle(SideTr, TriangleX, TriangleY);
                temp.Move(pictureBox1, clt, 4);
                TriangleX = temp.x;
                TriangleY = temp.y;
            }
            else if (radioButton4.Checked)
            {
                Circle temp = new Circle(RadiusC, CircleX, CircleY);
                temp.Move(pictureBox1, clc, 4);
                CircleX = temp.x;
                CircleY = temp.y;
            }
        }
    }
}

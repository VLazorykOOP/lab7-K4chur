using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
    
    public abstract class Figure
    {
        public uint id = 0;

        public abstract void Print(PictureBox pictureBox, int cl);
/*        public abstract void RandomMove1();*/
        public abstract void RandomMove(PictureBox pictureBox, int cl);
        public abstract void Move(PictureBox pictureBox, int cl, int direction);

    }

    public class Square : Figure
    {
        public uint side { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Square(uint side, int x, int y)
        {
            this.side = side;
            this.x = x;
            this.y = y;
        }

        public Square(TextBox textBox)
        {
            this.side = uint.Parse(textBox.Text);

            id++;
        }

        public override void Print(PictureBox pictureBox, int cl)
        {
            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)side;
            int leftwall = (int)pictureBox.Height - (int)side;

            this.x = rnd.Next(0,rightwall);
            this.y = rnd.Next(0,leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            } else if (cl == 2)
            {
                color = Color.Blue;
            } else if (cl == 3)
            {
                color = Color.Yellow;
            } else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen,x,y,side,side);
            }
        }

        public override void RandomMove(PictureBox pictureBox, int cl)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, this.x, this.y, side, side);
            }

            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)side;
            int leftwall = (int)pictureBox.Height - (int)side;
            this.x = rnd.Next(0, rightwall);
            this.y = rnd.Next(0, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, x, y, side, side);
            }

        }

        public override void Move(PictureBox pictureBox, int cl, int direction)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, this.x, this.y, side, side);
            }

            if (direction == 1)
            {
                y -= 10;
            } else if (direction == 2)
            {
                x += 10;
            } else if (direction == 3)
            {
                y += 10;
            } else if (direction == 4)
            {
                x -= 10;
            }
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, x, y, side, side);
            }
        }
    }

    public class Rectangle : Figure
    {
        public uint sidea;
        public uint sideb;
        public int x { get; set; }
        public int y { get; set; }
        public Rectangle(uint sidea, uint sideb, int x, int y)
        {
            this.sidea = sidea;
            this.sideb = sideb;
            this.x = x;
            this.y = y;
        }

        public Rectangle(TextBox textBox1, TextBox textBox2)
        {
            this.sidea = uint.Parse(textBox1.Text);
            this.sideb = uint.Parse(textBox2.Text);
            id++;
        }

        public override void Print(PictureBox pictureBox, int cl)
        {
            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)sidea;
            int leftwall = (int)pictureBox.Height - (int)sideb;

            x = rnd.Next(0, rightwall);
            y = rnd.Next(0, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, x, y, sidea, sideb);
            }
        }

        public override void RandomMove(PictureBox pictureBox, int cl)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, this.x, this.y, sidea, sideb);
            }

            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)sidea;
            int leftwall = (int)pictureBox.Height - (int)sideb;
            this.x = rnd.Next(0, rightwall);
            this.y = rnd.Next(0, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, x, y, sidea, sideb);
            }
        }

        public override void Move(PictureBox pictureBox, int cl, int direction)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, this.x, this.y, sidea, sideb);
            }

            if (direction == 1)
            {
                y -= 10;
            }
            else if (direction == 2)
            {
                x += 10;
            }
            else if (direction == 3)
            {
                y += 10;
            }
            else if (direction == 4)
            {
                x -= 10;
            }
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, x, y, sidea, sideb);
            }
        }
    }

    public class Triangle : Figure
    {
        public uint side { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Triangle(uint side, int x, int y)
        {
            this.side = side;
            this.x = x;
            this.y = y;
        }

        public Triangle(TextBox textBox)
        {
            this.side = uint.Parse(textBox.Text);
            id++;
        }

        public override void Print(PictureBox pictureBox, int cl)
        {
            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)side;
            int leftwall = (int)pictureBox.Height - (int)side;

            x = rnd.Next(0, rightwall);
            y = rnd.Next(0, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawLine(pen, x + side, y, x, y + side);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x + side, y);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x, y + side);
            }
        }

        public override void RandomMove(PictureBox pictureBox, int cl)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawLine(pen, x + side, y, x, y + side);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x + side, y);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x, y + side);
            }

            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)side;
            int leftwall = (int)pictureBox.Height - (int)side;
            this.x = rnd.Next(0, rightwall);
            this.y = rnd.Next(0, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawLine(pen, x + side, y, x, y + side);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x + side, y);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x, y + side);
            }
        }

        public override void Move(PictureBox pictureBox, int cl, int direction)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawLine(pen, x + side, y, x, y + side);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x + side, y);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x, y + side);
            }

            if (direction == 1)
            {
                y -= 10;
            }
            else if (direction == 2)
            {
                x += 10;
            }
            else if (direction == 3)
            {
                y += 10;
            }
            else if (direction == 4)
            {
                x -= 10;
            }
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawLine(pen, x + side, y, x, y + side);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x + side, y);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x, y + side);
            }
        }
    }

    public class Circle : Figure
    {
        public uint radius { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public Circle(uint radius, int x, int y)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }

        public Circle(TextBox textBox)
        {
            this.radius = uint.Parse(textBox.Text);
            id++;
        }

        public override void Print(PictureBox pictureBox, int cl)
        {
            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)radius;
            int leftwall = (int)pictureBox.Height - (int)radius;

            x = rnd.Next(0+(int)radius, rightwall);
            y = rnd.Next(0+(int)radius, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawEllipse(pen,x,y,radius,radius);
            }
        }

        public override void RandomMove(PictureBox pictureBox, int cl)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawEllipse(pen, x, y, radius, radius);
            }

            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)radius;
            int leftwall = (int)pictureBox.Height - (int)radius;
            this.x = rnd.Next(0 + (int)radius, rightwall);
            this.y = rnd.Next(0 + (int)radius, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawEllipse(pen, x, y, radius, radius);
            }
        }

        public override void Move(PictureBox pictureBox, int cl, int direction)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawEllipse(pen, x, y, radius, radius);
            }

            if (direction == 1)
            {
                y -= 10;
            }
            else if (direction == 2)
            {
                x += 10;
            }
            else if (direction == 3)
            {
                y += 10;
            }
            else if (direction == 4)
            {
                x -= 10;
            }
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawEllipse(pen, x, y, radius, radius);
            }
        }
    }
}

namespace Lab7CSharp
{
    partial class Form3
    {
        public

        int SquareX;
        int SquareY;
        int cls;
        uint SideSq;


        int CircleX;
        int CircleY;
        int clc;
        uint RadiusC;

 
        int TriangleX;
        int TriangleY;
        int clt;
        uint SideTr;


        int RecX;
        int RecY;
        int clr;
        uint SideReca;
        uint SideRecb;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати Фігуру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фігури";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(50, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Коло";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Трикутник";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Прямокутник";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Квадрат";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сторона Квадрату:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сторони Прямокутнику:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(283, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(345, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(235, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сторона Трик:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(225, 162);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 20);
            this.textBox5.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Радіус Кола:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 293);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Location = new System.Drawing.Point(125, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 65);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кольори";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(87, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Фіолетовий";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(87, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(65, 17);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Жовтий";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 42);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(52, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Синій";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 19);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(75, 17);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Червоний";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "/\\";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(468, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "\\/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(387, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(468, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "RMove";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 500);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private Button button6;
    }


}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private Graphics  graphics;
        private int resolution;
        private bool[,] field;
        private int rows;
        private int cols;
        private int currentGeneration;
        private int countDeadF;
        private int countDeadS;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            currentGeneration = 0;
            Text = $"Generation {currentGeneration}";

            nudResolution.Enabled = false;
            nudDesity.Enabled = false;
            resolution = (int)nudResolution.Value;
            rows = pictureBox1.Height / resolution;
            cols = pictureBox1.Width / resolution;
            field = new bool[cols, rows];

            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)nudDesity.Value) == 0;
                }
            }

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void nudResolution_ValueChanged(object sender, EventArgs e)
        {

        }
        private void NextGeneration()
        {
            graphics.Clear(Color.Black);
            countDeadF = (int)nudDepopulation.Value;
            countDeadS = (int)nudOverpop.Value;
            
            

            var nextFiled = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neigboursCont = CountNeibours(x, y);
                    var hasLife = field[x, y];

                    if (!hasLife && neigboursCont == countDeadF + 1)
                    {
                        nextFiled[x, y] = true;
                    }
                    else if (hasLife && (neigboursCont < countDeadF || neigboursCont > countDeadS))
                    {
                        nextFiled[x,y] = false;
                    }
                    else
                    {
                        nextFiled[x, y] = field[x, y];
                    }


                    if (hasLife)
                    {
                        graphics.FillRectangle(Brushes.White,x*resolution,y*resolution,resolution -1,resolution -1);
                    }
                }

            }           
            field = nextFiled;
            pictureBox1.Refresh();
            Text = $"Generation {++currentGeneration}";
        }
        private int CountNeibours(int x,int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols)% cols;
                    var row = (y + j+ rows)% rows;

                    var isSelfChecking = col == x && row == y;
                    var hasLife = field[col, row];
                    if (hasLife && !isSelfChecking)
                    {
                        count++;
                    }
                }
            }



            return count;
        }
        private void StopGame()
        {
            if (!timer1.Enabled)
                return;


            timer1.Enabled = false;
            nudDesity.Enabled = true;
            nudResolution.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void startBotton_Click(object sender, EventArgs e)
        {
            StartGame();
            
        }

        private void stopBotton_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(!timer1.Enabled)
                return ;
            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X/resolution;
                var y = e.Location.Y/resolution;
                var ValidationPassed = ValidateMousePosition(x, y);
                if (ValidationPassed)
                    field[x, y] = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var ValidationPassed = ValidateMousePosition(x, y);
                if(ValidationPassed)
                    field[x, y] = false;
            }
        }
        private bool ValidateMousePosition(int x, int y)
        {
            return x >=0 && y >= 0 && x < cols && y < rows;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = $"Generation {currentGeneration}";
        }
    }
}
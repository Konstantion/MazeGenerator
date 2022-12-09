﻿using MazeGenerator.core.maze.implementation.BFS;
using MazeGenerator.core.maze.implementation.Kruskal;
using MazeGenerator.core.algorithms;
using MazeGenerator.core.maze.implementation;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MazeGenerator
{

    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bitmap;

        private bool IsOnBFSMode;
        private Maze maze;        

        Random random;
        public Form1()
        {            
            InitializeComponent();
            SetAlgorithmComboBoxData();

            bitmap = new Bitmap(pictureBoxMaze.Width, pictureBoxMaze.Height);
            g = Graphics.FromImage(bitmap);

            IsOnBFSMode = false;

            random = new Random();

            initMaze();
        }
        private void SetAlgorithmComboBoxData()
        {
            this.comboBoxAlgorithm.DataSource = new AlgorithmComboItem[]
           {
                new AlgorithmComboItem("Kruskal's Algorithm",1),
                new AlgorithmComboItem("Prim's Algorithm",2)
           };
            this.comboBoxAlgorithm.DisplayMember = "Name";
            this.comboBoxAlgorithm.ValueMember = "Id";
        }        

        private void numericUpDownMazeSize_ValueChanged(object sender, EventArgs e)
        {
            initMaze();
        }

        private void comboBoxAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxMaze.Image = bitmap;
            maze.Animate();            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            labelIsRunning.Text = "Execution is running";
            Console.WriteLine($"Timer start with interval {timer1.Interval}");
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            labelIsRunning.Text = "Execution is stoped";
        }        

        private void initMaze()
        {
            IsOnBFSMode = false;

            pictureBoxMaze.Image = bitmap;

            int n = (int)numericUpDownMazeSize.Value;
            maze = new Kruskal(n, pictureBoxMaze.Width, pictureBoxMaze.Height, g);

            maze.Draw();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            IsOnBFSMode = false;
            initMaze();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            pictureBoxMaze.Image = bitmap;
            maze.Animate();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            pictureBoxMaze.Image = bitmap;
            timer1.Stop();
            maze.Finish();

            labelIsRunning.Text = "Execution is stoped";
        }

        private void pictureBoxMaze_Click(object sender, EventArgs e)
        {
            if (maze.isFinished 
                && maze.GetType() == typeof(BFS)
                && maze is BFS temp
                && !temp.isCellFounded
                )
            {
                pictureBoxMaze.Image = bitmap;
                
                MouseEventArgs me = (MouseEventArgs)e;
                Point coordinates = me.Location;

                switch (me.Button)
                {

                    case MouseButtons.Left:
                        temp.SetPoint(coordinates, true);
                        break;

                    case MouseButtons.Right:
                        temp.SetPoint(coordinates, false);
                        break;
                }                       

                temp.BFSDraw();

                maze = temp;                
            }
        }

        private void buttonBFS_Click(object sender, EventArgs e)
        {
            if (maze.isFinished && !IsOnBFSMode)
            {
                IsOnBFSMode = true;
                pictureBoxMaze.Image = bitmap;
                maze = new BFS(maze);
                maze.Draw();                
            }
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            int fps = (int)trackBarSpeed.Value;
            int interval = 1000 / fps;
            timer1.Interval = interval;
        }
    }
}

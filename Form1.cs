using MazeGenerator.core.maze.implementation.BFS;
using MazeGenerator.core.maze.implementation.Kruskal;
using MazeGenerator.core.algorithms;
using MazeGenerator.core.maze.implementation;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace MazeGenerator
{

    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bitmap;

        private bool IsOnBFSMode;
        private Maze maze; 
        public Form1()
        {            
            InitializeComponent();
            SetAlgorithmComboBoxData();
            SetOpenFileComboBoxData();

            bitmap = new Bitmap(pictureBoxMaze.Width, pictureBoxMaze.Height);
            g = Graphics.FromImage(bitmap);

            IsOnBFSMode = false;           

            initMaze();
        }

        private void SetOpenFileComboBoxData()
        {
            string[] files = Directory.GetFiles(Maze.SAVE_DIRECTORY);

            ComboItem[] items = new ComboItem[files.Length];

            for(int i = 0; i < files.Length; i++)
            {
                items[i] = new ComboItem(files[i].Substring(Maze.SAVE_DIRECTORY.Length), files[i]);
            }

            comboBoxOpen.DataSource = items;

            comboBoxAlgorithm.DisplayMember = "Name";
            comboBoxAlgorithm.ValueMember = "Id";
        }

        private void SetAlgorithmComboBoxData()
        {
           comboBoxAlgorithm.DataSource = new ComboItem[]
           {
                new ComboItem("Kruskal's Algorithm","1"),
                new ComboItem("Prim's Algorithm","2")
           };
           comboBoxAlgorithm.DisplayMember = "Name";
            comboBoxAlgorithm.ValueMember = "Id";
        }        

        private void numericUpDownMazeSize_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numericUpDownMazeSize.Value - 1;

            numericUpDownWalls.Maximum = n * n;

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
            int walls = (int)numericUpDownWalls.Value;

            labelWallInfo.Text = "Walls will be deleted\n" + walls;

            Kruskal kruskal = new Kruskal(n, pictureBoxMaze.Width, pictureBoxMaze.Height, g);
            kruskal.SetWallsToBreak(walls);

            maze = kruskal;

            maze.Draw();

            buttonStop.PerformClick();
        }

        private void numericUpDownWalls_ValueChanged(object sender, EventArgs e)
        {
            initMaze();
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
            
            maze.Finish();

            buttonStop.PerformClick();
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

                buttonStop.PerformClick();
            }
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            int speed = (int)trackBarSpeed.Value;
            int interval = 1000 / speed;
            timer1.Interval = interval;
            labelIsRunning.Text = "Execution is running with interval\n" + timer1.Interval + "m";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(maze.isFinished)
            {
                String name = richTextBoxName.Text;
                maze.SaveMaze(name);
                SetOpenFileComboBoxData();
            }            
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            pictureBoxMaze.Image = bitmap;

            IsOnBFSMode = false;           
            string path = comboBoxOpen.SelectedValue.ToString();

            maze = new Maze(path, pictureBoxMaze.Width, pictureBoxMaze.Height, g);
        }
    }
}

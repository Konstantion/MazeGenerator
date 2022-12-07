using MazeGenerator.core.maze.implementation.Kruskal;
using MazeGenerator.src.algorithms;
using MazeGenerator.src.maze.implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MazeGenerator.src.maze.DrawingTools;

namespace MazeGenerator{
   
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bitmap;        
        int counter;

        private Maze maze;

        Random random;
        public Form1()
        {            
            InitializeComponent();
            SetAlgorithmComboBoxData();

            bitmap = new Bitmap(pictureBoxMaze.Width, pictureBoxMaze.Height);
            g = Graphics.FromImage(bitmap);            

            counter = 0;
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
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            Console.WriteLine($"Timer start with interval {timer1.Interval}");
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void numericUpDownFrames_ValueChanged(object sender, EventArgs e)
        {
            int fps = (int)numericUpDownFrames.Value;
            int interval = 1000 / fps;
            timer1.Interval = interval;
        }

        private void initMaze()
        {
            pictureBoxMaze.Image = bitmap;

            int n = (int)numericUpDownMazeSize.Value;
            maze = new Kruskal(n, pictureBoxMaze.Width, pictureBoxMaze.Height, g);

            maze.Drow();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            counter = 0;
            initMaze();
        }
    }
}

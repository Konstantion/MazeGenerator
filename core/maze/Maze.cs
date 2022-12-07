
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MazeGenerator.src.maze.DrawingTools;

namespace MazeGenerator.src.maze.implementation
{
    class Maze
    {
        public const int N = 1;
        public const int S = 2;
        public const int E = 4;
        public const int W = 8;
       
        protected Random random = null;
        protected int seed;
        protected int n;
        protected int w = 0;
        protected int h = 0;
        protected Cell[][] grid = null;
        

        protected Graphics g;
        protected bool isAnimating = true;
    

        public Maze(int n, int w, int h, Graphics g)
        {
            this.g = g;

            this.n = n;
           
            random = new Random();

            Initialize(w, h);
        }

        public Maze(int n, int w, int h, Graphics g, int seed)
        {
            this.g = g;

            this.n = n;

            random = new Random(seed);

            Initialize(w, h);
        }

        private void Initialize(int w, int h)
        {
            this.w = w;
            this.h = h;

            grid = new Cell[h][];

            float cellSize = (float)(w * 1.0) / n;

            for (int j = 0; j < n; j++)
            {
                grid[j] = new Cell[w];
                float y = j * cellSize;

                for (int i = 0; i< n; i++)
                {
                    float x = i * cellSize;
                    grid[j][i] = new Cell(cellSize, x, y, g, 0);
                }
            }
        }

        public void Drow()
        {
            g.Clear(Color.White);

            for(int j = 0; j< n; j++)
            {
                for(int i = 0; i < n; i++)
                {
                    grid[j][i].DrawCell();
                    grid[j][i].DrawNorthWall();
                    grid[j][i].DrawWesthWall();
                    grid[j][i].EraseWesthWall();
                    grid[j][i].EraseNorthWall();

                }
            }

            g.DrawLine(BLACK_PEN, 0, 0, 0, h);
        }
        public static int DX(int direction)
        {
            switch (direction)
            {
                case Maze.E:
                    return +1;
                case Maze.W:
                    return -1;
                case Maze.N:
                case Maze.S:
                    return 0;
            }
           
            return -1;
        }
        public static int DY(int direction)
        {
            switch (direction)
            {
                case Maze.E:
                case Maze.W:
                    return 0;
                case Maze.N:
                    return -1;
                case Maze.S:
                    return 1;
            }
            // error condition, but should never reach here
            return -1;
        }
        public static int OPPOSITE(int direction)
        {
            switch (direction)
            {
                case Maze.E:
                    return Maze.W;
                case Maze.W:
                    return Maze.E;
                case Maze.N:
                    return Maze.S;
                case Maze.S:
                    return Maze.N;
            }
            
            return -1;
        }

        public void setAnimate(bool isAnimating)
        {
            this.isAnimating = isAnimating;
        }
    }
}

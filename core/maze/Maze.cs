using System;
using System.Drawing;
using static MazeGenerator.core.maze.DrawingTools;

namespace MazeGenerator.core.maze.implementation
{
    class Maze
    {
        public const int N = 1;
        public const int S = 2;
        public const int E = 4;
        public const int W = 8;
        
       
        protected Random random;
        protected int seed;
        protected int n;
        protected int w = 0;
        protected int h = 0;
        protected Cell[][] grid;
        

        protected Graphics g;
        protected bool isAnimating = true;
        public bool isFinished = false;
    
        protected Maze(Maze maze)
        {
            this.g = maze.g;
            this.grid = (Cell[][]) maze.grid.Clone();
            this.n = maze.n;
            this.w = maze.w;
            this.h = maze.h;
            this.random = maze.random;
            this.isFinished = maze.isFinished;
        }
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

            grid = new Cell[n][];

            float cellSize = (float)(w * 1.0) / n;

            for (int j = 0; j < n; j++)
            {
                grid[j] = new Cell[n];
                float y = j * cellSize;

                for (int i = 0; i< n; i++)
                {
                    float x = i * cellSize;
                    grid[j][i] = new Cell(cellSize, x, y, g, 0, i , j);
                }
            }
        }

        public virtual void Draw()
        {
            DrawEmptyMaze();

            for (int j = 0; j< n; j++)
            {
                for(int i = 0; i < n; i++)
                {
                    DrawDefaultCell(i, j);

                    CheckWall(i, j, N);

                    CheckWall(i, j, E);

                    CheckWall(i, j, S);

                    CheckWall(i, j, W);
                }
            }           
        }

        public virtual void Animate()
        {
            Draw();
        }

        public virtual void Finish()
        {
            Draw();
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

        protected void CheckWall(int i, int j, int DIRECTION)
        {
            if ((grid[j][i].val & DIRECTION) != 0)
            {
                grid[j][i].EraseWall(DIRECTION, WHITE_PEN);
            }
            else
            {
                grid[j][i].DrawWall(DIRECTION, BLACK_PEN);
            }
        }

        protected void DrawEmptyMaze()
        {
            g.Clear(Color.White);
            g.DrawLine(BLACK_PEN, 0, 0, 0, h);
            g.DrawLine(BLACK_PEN, 0, 0, w, 0);
            g.DrawLine(BLACK_PEN, w, 0, w, h);
            g.DrawLine(BLACK_PEN, 0, h, w, h);
        }

        protected void DrawDefaultCell(int i, int j)
        {
            if (grid[j][i].val == 0)
            {
                grid[j][i].DrawCell();
            }
            else
            {
                grid[j][i].DrawCell(WHITE_BRUSH);
            }
        }

        
    }
}

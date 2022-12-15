using System;
using System.Drawing;
using System.IO;
using System.Text;
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
        public bool IsOnBFSMode = false;  

        private const String DEFAULT_NAME = "maze";
        private const String SAVE_FOLDER = "\\maze saves\\";
        public static readonly String SAVE_DIRECTORY = Directory.GetParent(Environment.CurrentDirectory)
                .Parent
                .FullName +
                SAVE_FOLDER;

        protected Maze(Maze maze)
        {
            this.g = maze.g;
            this.grid = (Cell[][])maze.grid.Clone();
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

        public Maze(string path, int w, int h, Graphics g)
        {
            this.g = g;

            InitMazeFromPath(path, w, h);
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

                for (int i = 0; i < n; i++)
                {
                    float x = i * cellSize;
                    grid[j][i] = new Cell(cellSize, x, y, g, 0, i, j);
                }
            }
        }

        public virtual void Draw()
        {
            DrawEmptyMaze();

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
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

        protected int GetRandomDirection()
        {
            int[] directions = new int[4] { N, S, E, W };

            return directions[random.Next(directions.Length)];
        }

        public void SaveMaze(String name)
        {
            String maze = BuildMazeString();

            if(String.IsNullOrEmpty(name))
            {
                SaveMazeToFile(DEFAULT_NAME, maze);
            }
            else
            {
                SaveMazeToFile(name, maze);
            }
        }      

        private void SaveMazeToFile(String name, String maze)
        {            
            string path = SAVE_DIRECTORY +
                name + ".txt";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, maze);
            }
            else
            {
                SaveMazeToFile(name + "-new", maze);
            }
        }

        private String BuildMazeString()
        {
            StringBuilder mazeBuilder = new StringBuilder();                       

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int val = GetCellValue(grid[i][j]);
                    mazeBuilder.Append(val + " ");
                    
                }
                mazeBuilder.Append("\n");
            }
            
            mazeBuilder.Append(" ");
            for (int i = 0; i < (n * 2 - 1); ++i)
            {
                mazeBuilder.Append("_");
            }
            mazeBuilder.Append("\n");


            for (int j = 0; j < n; ++j)
            {
                mazeBuilder.Append("|");
                for (int i = 0; i < n; ++i)
                {
                    mazeBuilder.Append((grid[j][i].val & Maze.S) != 0 ? " " : "_");

                    if ((grid[j][i].val & Maze.E) != 0)
                    {
                        mazeBuilder.Append(((grid[j][i].val | grid[j][i + 1].val) & Maze.S) != 0 ? " " : "_");
                    }
                    else
                    {
                        mazeBuilder.Append("|");
                    }
                }
                mazeBuilder.Append("\n");
            }

            return mazeBuilder.ToString();
        }

        protected virtual void InitMazeFromPath(string path, int w, int h)
        {
            string[] mazeStrings = File.ReadAllLines(path);

            this.n = mazeStrings[0].Trim().Split(' ').Length;

            Initialize(w, h);

            for(int i = 0; i < n; i++)
            {
                int[] values = Array.ConvertAll(mazeStrings[i].Trim().Split(' '), Convert.ToInt32);
                for(int j = 0; j < n; j++)
                {
                    grid[i][j].val = values[j];
                }
            }

            isFinished = true;
            isAnimating = false;

            Draw();
        }

        private int GetCellValue(Cell cell)
        {
            return cell.val & (N + E + W + S);
        }


    }
}

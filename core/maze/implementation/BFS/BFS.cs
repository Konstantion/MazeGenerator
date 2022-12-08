using MazeGenerator.core.maze;
using MazeGenerator.core.maze.implementation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MazeGenerator.core.maze.DrawingTools;

namespace MazeGenerator.core.maze.implementation.BFS
{
    class BFS : Maze
    {
        public const int START = 16;
        public const int END = 32;
        public const int DEQUEUED = 64;
        public const int ENQUEUED = 128;
        private BFSPoint start;
        private BFSPoint end;
        private bool isStart = true;
        private Queue<Cell> queue;

        private BFS(int n, int w, int h, Graphics g) : base(n, w, h, g)
        {

        }

        private BFS(int n, int w, int h, Graphics g, int seed) : base(n, w, h, g, seed)
        {

        }



        public BFS(Maze maze) : base(maze)
        {
            Initialize();
        }

        private void Initialize()
        {
            queue = new Queue<Cell>();
            start = new BFSPoint(0, 0);
            end = new BFSPoint(n - 1, n - 1);
            grid[start.y][start.x].val |= START;
            grid[end.y][end.x].val |= END;
        }

        public override void Animate()
        {
            
        }
        public void SetPoint(Point point)
        {
            if(isStart)
            {
                grid[start.y][start.x].val -= START;

                start = CalcIndexFromPoint(point);

                grid[start.y][start.x].val |= START;

                isStart = false;
            }
            else
            {
                grid[end.y][end.x].val -= END;

                end = CalcIndexFromPoint(point);

                grid[end.y][end.x].val |= END;

                isStart = true;
            }
        }     
        
        private BFSPoint CalcIndexFromPoint(Point point)
        {
            float cellSize = (float)(w * 1.0) / n;
            int index_x = Convert.ToInt32(Math.Ceiling(point.X / cellSize)) - 1;
            int index_y = Convert.ToInt32(Math.Ceiling(point.Y / cellSize)) - 1;
           
            return new BFSPoint(index_x, index_y);
        }

        public override void Draw()
        {
            g.Clear(Color.White);
            g.DrawLine(BLACK_PEN, 0, 0, 0, h);
            g.DrawLine(BLACK_PEN, 0, 0, w, 0);
            g.DrawLine(BLACK_PEN, w, 0, w, h);
            g.DrawLine(BLACK_PEN, 0, h, w, h);

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    BFSDrawCell(i, j);

                    CheckWall(i, j, N);

                    CheckWall(i, j, E);

                    CheckWall(i, j, S);

                    CheckWall(i, j, W);
                }
            }
            Console.WriteLine("i paint bfs base");
                        
        }
        private void BFSDrawCell(int i, int j)
        {
            if (grid[j][i].val == 0)
            {
                grid[j][i].DrawCell();
            }
            else if ((grid[j][i].val & START) != 0)
            {
                grid[j][i].DrawCell(GREEN_BRUSH);
            }
            else if ((grid[j][i].val & END) != 0)
            {
                grid[j][i].DrawCell(AQUAMARINE_BRUSH);
            }
            else if ((grid[j][i].val & DEQUEUED) != 0)
            {
                grid[j][i].DrawCell(DARK_BLUE_BRUSH);
            }
            else if ((grid[j][i].val & ENQUEUED) != 0)
            {
                grid[j][i].DrawCell(BLUE_BRUSH);
            }
            else
            {
                grid[j][i].DrawCell(WHITE_BRUSH);
            }
        }
    }

}

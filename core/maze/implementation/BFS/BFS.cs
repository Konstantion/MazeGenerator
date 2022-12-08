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
        public const int END = 16;
        public const int DEQUEUED = 64;
        public const int EQUEUED = 128;
        private BFSPoint start;
        private BFSPoint end;
        private bool isStart = true;
        private Queue<Cell>
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
            start = new BFSPoint(0, 0);
            end = new BFSPoint(n - 1, n - 1);
        }

        public void SetPoint(Point point)
        {
            if(isStart)
            {
                start = CalcIndexFromPoint(point);
                isStart = false;
            }
            else
            {
                end = CalcIndexFromPoint(point);
                isStart = true;
            }
        }     
        
        private BFSPoint CalcIndexFromPoint(Point point)
        {
            float cellSize = (float)(w * 1.0) / n;
            int index_x = Convert.ToInt32(point.X / cellSize);
            int index_y = Convert.ToInt32(point.Y / cellSize);
            return new BFSPoint(index_x, index_y);
        }

        public virtual void Draw()
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
                    if (grid[j][i].val == 0)
                    {
                        grid[j][i].DrawCell();
                    }
                    else
                    {
                        grid[j][i].DrawCell(WHITE_BRUSH);
                    }

                    if ((grid[j][i].val & S) != 0)
                    {
                        grid[j][i].EraseSouthWall();
                    }
                    else
                    {
                        grid[j][i].DrawSouthWall();
                    }

                    if ((grid[j][i].val & W) != 0)
                    {
                        grid[j][i].EraseWestWall();
                    }
                    else
                    {
                        grid[j][i].DrawWestWall();
                    }

                    if ((grid[j][i].val & N) != 0)
                    {
                        grid[j][i].EraseNorthWall();
                    }
                    else
                    {
                        grid[j][i].DrawNorthWall();
                    }

                    if ((grid[j][i].val & E) != 0)
                    {
                        grid[j][i].EraseEastWall();
                    }
                    else
                    {
                        grid[j][i].DrawEastWall();
                    }
                }
            }
            Console.WriteLine("i paint bfs base");
        }
    }
}

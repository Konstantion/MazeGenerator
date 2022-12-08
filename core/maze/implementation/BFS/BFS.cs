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
        public bool isCellFounded = false;
        private bool isPathBuilt = false;

        private Queue<Cell> queue;
        private BFSTree pathTree;

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

            grid[start.y][start.x].val |= START;
            grid[end.y][end.x].val |= END;

            queue = new Queue<Cell>();
            pathTree = new BFSTree(grid[start.y][start.x]);

            queue.Enqueue(grid[start.y][start.x]);
        }

        private void DoStepInDepth()
        {
            if(queue.Count > 0 && !isCellFounded)
            {
                Cell current = queue.Dequeue();

                current.val -= ENQUEUED;
                current.val |= DEQUEUED;

                Console.WriteLine($"Current {current}");

                if(current.Equals(grid[end.y][end.x]))
                {
                    isCellFounded = true;
                    return;
                }

                List<Cell> neighborCells = ExtractNeighborCells(current);

                Console.WriteLine("Enqueue elements:");

                foreach (Cell cell in neighborCells)
                {
                    Console.WriteLine(cell);
                    queue.Enqueue(cell);
                    cell.val |= ENQUEUED;
                }
            }
        }

        public override void Animate()
        {
            DoStepInDepth();
            BFSDraw();
        }

        public void SetPoint(Point point)
        {
            if(isStart)
            {
                grid[start.y][start.x].val -= START;

                start = CalcIndexFromPoint(point);

                grid[start.y][start.x].val |= START;

                isStart = false;

                queue = new Queue<Cell>();
                queue.Enqueue(grid[start.y][start.x]);                
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

        private void BFSDraw()
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

                    BFSCheckWall(i, j, N);

                    BFSCheckWall(i, j, E);

                    BFSCheckWall(i, j, S);

                    BFSCheckWall(i, j, W);
                }
            }
            Console.WriteLine("i paint bfs base");

        }

        private void BFSDrawCell(int i, int j)
        {
            if (grid[j][i].val == 0)
            {
                grid[j][i].DrawFullCell(GREEN_BRUSH);
            }
            else if ((grid[j][i].val & START) != 0)
            {
                grid[j][i].DrawFullCell(GREEN_BRUSH);
            }
            else if ((grid[j][i].val & END) != 0)
            {
                grid[j][i].DrawFullCell(AQUAMARINE_BRUSH);
            }
            else if ((grid[j][i].val & DEQUEUED) != 0)
            {
                grid[j][i].DrawFullCell(LIGHT_BLUE_BRUSH);
            }
            else if ((grid[j][i].val & ENQUEUED) != 0)
            {
                grid[j][i].DrawFullCell(BLUE_BRUSH);
            }
            else
            {
                grid[j][i].DrawFullCell(WHITE_BRUSH);
            }
        }

        protected void BFSCheckWall(int i, int j, int DIRECTION)
        {
            if ((grid[j][i].val & DIRECTION) == 0)
            {
                grid[j][i].DrawWall(DIRECTION, BLACK_PEN);
            }          
        }

        private List<Cell> ExtractNeighborCells(Cell cell)
        {
            List<Cell> cells = new List<Cell>();

            if (((cell.val & E) != 0) && (grid[cell.Y][cell.X + 1].val & DEQUEUED) == 0) 
                cells.Add(grid[cell.Y][cell.X+1]);
            
            if ((cell.val & W) != 0 && (grid[cell.Y][cell.X - 1].val & DEQUEUED) == 0) 
                cells.Add(grid[cell.Y][cell.X-1]);
            
            if ((cell.val & N) != 0 && (grid[cell.Y - 1][cell.X].val & DEQUEUED) == 0) 
                cells.Add(grid[cell.Y -1][cell.X]);
            
            if ((cell.val & S) != 0 && (grid[cell.Y + 1][cell.X].val & DEQUEUED) == 0) 
                cells.Add(grid[cell.Y + 1][cell.X]);

            return cells;
        }
    }

}

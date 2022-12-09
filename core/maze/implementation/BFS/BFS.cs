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
        public const int VISITED = 64;
        public const int ENQUEUED = 128;

        private BFSPoint start;
        private BFSPoint end;

        
        public bool isCellFounded = false;
        public bool isPathFounded = false;
        public bool isPathDrawn = false;
        

        private Queue<Cell> bfsQueue;
        private Queue<Cell> pathQueue;

        private List<List<BFSTree>> pathTree;  

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

            bfsQueue = new Queue<Cell>();      
            bfsQueue.Enqueue(grid[start.y][start.x]);

            pathQueue = new Queue<Cell>();
            pathTree = new List<List<BFSTree>>();
            for (int y = 0; y < n; ++y)
            {
                List<BFSTree> temp = new List<BFSTree>();
                for (int x = 0; x < n; ++x)
                {
                    temp.Add(new BFSTree(grid[y][x]));
                }
                pathTree.Add(temp);
            }
        }

        private void ExecuteEntireAlgorithm()
        {
            while(bfsQueue.Count > 0 && !isCellFounded)
            {
                DoStepInDepth();
            }

            FindPath();

            while (pathQueue.Count > 0) {
                BuildPath();
            }
        }

        private void DoStepInDepth()
        {           
            Cell current = bfsQueue.Dequeue();

            current.val -= ENQUEUED;
            current.val |= VISITED;           

            if(current.Equals(grid[end.y][end.x]))
            {
                isCellFounded = true;
                return;
            }

            List<Cell> neighborCells = ExtractNeighborCells(current);

            Console.WriteLine("Enqueue elements:");

            foreach (Cell cell in neighborCells)
            {
                pathTree[cell.Y][cell.X].SetPerent(pathTree[current.Y][current.X]);

                if ((cell.val & VISITED) == 0)
                {
                    bfsQueue.Enqueue(cell);
                    cell.val |= ENQUEUED;
                }
            }                        
        }

        private void FindPath()
        {
            while (!pathTree[end.y][end.x].cell
                   .Equals(pathTree[start.y][start.x].cell))
            {
                pathQueue.Enqueue(grid[end.y][end.x]);

                int perent_x = pathTree[end.y][end.x].parent.cell.X;
                int perent_y = pathTree[end.y][end.x].parent.cell.Y;

                end.y = perent_y;
                end.x = perent_x;               
            }

            isPathFounded = true;
        }

        private void BuildPath()
        {
            if(pathQueue.Count > 0)
            {
                Cell temp = pathQueue.Dequeue();

                temp.val -= VISITED;
                temp.val += START;
            }
            else
            {
                isPathDrawn = true;
            }
        }

        public override void Animate()
        {
            if (bfsQueue.Count > 0 && !isCellFounded)
            {
                DoStepInDepth();
            }
            else if ((isCellFounded || bfsQueue.Count == 0) && !isPathFounded)
            {
                FindPath();
            }
            else if (!isPathDrawn) 
            {
                BuildPath(); 
            }

            BFSDraw();
        }

        public override void Finish()
        {
            ExecuteEntireAlgorithm();

            BFSDraw();
        }

        public void SetPoint(Point point, bool isLeft)
        {
            if(isLeft)
            {  
                BFSPoint new_start = CalcIndexFromPoint(point);

                if (!PointCanBeMarked(new_start)) return;                

                grid[start.y][start.x].val -= START;                            

                ClearCellFromBFSStatuses(new_start.x, new_start.y);

                grid[new_start.y][new_start.x].val |= START;

                

                start = new_start;

                bfsQueue = new Queue<Cell>();
                bfsQueue.Enqueue(grid[start.y][start.x]);                
            }
            else
            {
                BFSPoint new_end = CalcIndexFromPoint(point);

                if (!PointCanBeMarked(new_end)) return;                

                grid[end.y][end.x].val -= END;               

                ClearCellFromBFSStatuses(new_end.x, new_end.y);

                grid[new_end.y][new_end.x].val |= END;

                end = new_end;
            }
        }     
        
        private BFSPoint CalcIndexFromPoint(Point point)
        {
            float cellSize = (float)(w * 1.0) / n;
            int index_x = Convert.ToInt32(Math.Ceiling(point.X / cellSize)) - 1;
            int index_y = Convert.ToInt32(Math.Ceiling(point.Y / cellSize)) - 1;
           
            return new BFSPoint(index_x, index_y);
        }

        private bool PointCanBeMarked(BFSPoint bfsPoint)
        {
            return (grid[bfsPoint.y][bfsPoint.x].val & VISITED) == 0 
                && (grid[bfsPoint.y][bfsPoint.x].val & ENQUEUED) == 0
                && (grid[bfsPoint.y][bfsPoint.x].val & START) == 0
                && (grid[bfsPoint.y][bfsPoint.x].val & END) == 0;
        }

        private void ClearCellFromBFSStatuses(Cell cell)
        {
            if ((cell.val & VISITED) != 0) cell.val -= VISITED;
            if ((cell.val & ENQUEUED) != 0) cell.val -= ENQUEUED;
            if ((cell.val & START) != 0) cell.val -= START;
            if ((cell.val & END) != 0) cell.val -= END;
        }

        private void ClearCellFromBFSStatuses(int i, int j)
        {
            ClearCellFromBFSStatuses(grid[j][i]);
        }

        public override void Draw()
        {
            DrawEmptyMaze();

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
        }

        public void BFSDraw()
        {
            DrawEmptyMaze();

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
            else if ((grid[j][i].val & VISITED) != 0)
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

            if (((cell.val & E) != 0) && (grid[cell.Y][cell.X + 1].val & VISITED) == 0) 
                cells.Add(grid[cell.Y][cell.X+1]);
            
            if ((cell.val & W) != 0 && (grid[cell.Y][cell.X - 1].val & VISITED) == 0) 
                cells.Add(grid[cell.Y][cell.X-1]);
            
            if ((cell.val & N) != 0 && (grid[cell.Y - 1][cell.X].val & VISITED) == 0) 
                cells.Add(grid[cell.Y -1][cell.X]);
            
            if ((cell.val & S) != 0 && (grid[cell.Y + 1][cell.X].val & VISITED) == 0) 
                cells.Add(grid[cell.Y + 1][cell.X]);

            return cells;
        }
    }

}

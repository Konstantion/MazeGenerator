﻿using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using static MazeGenerator.core.maze.DrawingTools;

namespace MazeGenerator.core.maze.implementation.Kruskal
{
    class Kruskal : Maze
    {
        public const int SELECTED = 16;

        private List<List<Tree>> sets;
        private Stack<Edge> edges;

        public Kruskal(int n, int w, int h, Graphics g) : base(n, w, h ,g)
        {    
            Initialize();
        }

        public Kruskal(int n, int w, int h, Graphics g, int seed) : base(n, w, h, g, seed)
        {
            Initialize();
        }

        private void Initialize()
        {
            sets = new List<List<Tree>>();
            for(int y = 0; y < n; ++y )
            {
                List<Tree> temp = new List<Tree>();
                for(int x = 0; x < n; ++x)
                {
                    temp.Add(new Tree());
                }
                sets.Add(temp);
            }

            edges = new Stack<Edge>();
            for (int y = 0; y < n; ++y)
            {
                for (int x = 0; x < n; ++x)
                {
                    if (y > 0) { edges.Push(new Edge(x, y, Maze.N)); }
                    if (x > 0) { edges.Push(new Edge(x, y, Maze.W)); }
                }
            }

            Shuffle(edges);            
        }

        private void CarvePassage()
        {
            if(edges.Count > 0)
            {
                Edge temp = edges.Pop();

                int x = temp.GetX();
                int y = temp.GetY();
                int direction = temp.GetDirection();

                int dx = x + Maze.DX(direction);
                int dy = y + Maze.DY(direction);

                Tree set1 = sets[y][x];
                Tree set2 = sets[dy][dx];

                if (!set1.Connected(set2))
                {
                    set1.Connect(set2);


                    grid[y][x].val |= direction;                    
                    grid[dy][dx].val |= Maze.OPPOSITE(direction);                                     
                }

                grid[y][x].val |= SELECTED;
                grid[dy][dx].val |= SELECTED;
            }
            else
            {
                isFinished = true;
            }
        }

        private void CarvePassages()
        {
            while (edges.Count > 0)
            {
                Edge temp = edges.Pop();

                int x = temp.GetX();
                int y = temp.GetY();
                int direction = temp.GetDirection();

                int dx = x + Maze.DX(direction);
                int dy = y + Maze.DY(direction);

                Tree set1 = sets[y][x];
                Tree set2 = sets[dy][dx];

                if (!set1.Connected(set2))
                {
                    set1.Connect(set2);

                    grid[y][x].val |= direction;                    
                    grid[dy][dx].val |= Maze.OPPOSITE(direction);                    
                }
            } 
            isFinished = true;            
        }

        public override void Animate()
        {
            CarvePassage();
            Draw();
        }

        public override void Draw()
        {
            DrawEmptyMaze();

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    DrawKruskalCell(i, j);

                    CheckWall(i, j, N);

                    CheckWall(i, j, E);

                    CheckWall(i, j, S);

                    CheckWall(i, j, W);
                }
            }            
        }

        private void DrawKruskalCell(int i, int j)
        {
            if (grid[j][i].val == 0)
            {
                grid[j][i].DrawCell();
            }
            else if ((grid[j][i].val & SELECTED) != 0)
            {
                grid[j][i].DrawCell(YELLOW_BRUSH);
                grid[j][i].val -= SELECTED;

            }
            else
            {
                grid[j][i].DrawCell(WHITE_BRUSH);
            }
        }

        public override void Finish()
        {
            CarvePassages();
            Draw();
        }

        public void Shuffle(Stack<Edge> stack)
        {
            var values = stack.ToArray();
            stack.Clear();
            foreach (var value in values.OrderBy(x => random.Next()))
                stack.Push(value);
        }
    }
}

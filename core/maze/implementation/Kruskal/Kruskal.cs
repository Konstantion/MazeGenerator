using MazeGenerator.src.maze.implementation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.core.maze.implementation.Kruskal
{
    class Kruskal : Maze
    {
        private List<List<Tree>> sets;
        private Stack<Edge> edges;

        public Kruskal(int n, int w, int h, Graphics g) : base(n, w, h ,g)
        {    
            Initialize(w, h);
        }

        public Kruskal(int n, int w, int h, Graphics g, int seed) : base(n, w, h, g, seed)
        {
            Initialize(w, h);
        }

        private void Initialize(int w, int h)
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

            carvePassages();
        }

        private void carvePassages()
        {
            while(edges.Count > 0)
            {
                Edge temp = edges.Pop();

                int x = temp.getX();
                int y = temp.getY();
                int direction = temp.getDirection();

                int dx = x + Maze.DX(direction);
                int dy = y + Maze.DY(direction);

                Tree set1 = sets[y][x];
                Tree set2 = sets[dy][dx];

                if (!set1.connected(set2))
                {
                    set1.connect(set2);

                    grid[y][x].val |= direction;
                    grid[dy][dx].val |= Maze.OPPOSITE(direction);
                }
            }
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

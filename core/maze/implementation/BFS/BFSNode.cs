using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.core.maze.implementation.BFS
{
    class BFSNode
    {
        public Cell cell;
        public List<BFSNode> children;      

        public BFSNode(Cell cell)
        {
            this.cell = cell;
            children = new List<BFSNode>();
        }
    }
}

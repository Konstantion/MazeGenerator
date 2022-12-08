using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.core.maze.implementation.BFS
{
    class BFSTree
    {
        BFSNode root;       

        public BFSTree(Cell cell)
        {
            root = new BFSNode(cell);           
        }
       
    }
}

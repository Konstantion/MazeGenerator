using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.core.maze.implementation.BFS
{
    class BFSPoint
    {       
        public int x;
        public int y;
       
        public BFSPoint(int index_x, int index_y)
        {
            this.x = index_x;
            this.y = index_y;
        }                
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.core.maze.implementation.BFS
{
    class BFSPoint
    {       
        int index_x;
        int index_y;
       
        public BFSPoint(int index_x, int index_y)
        {
            this.index_x = index_x;
            this.index_y = index_y;
        }

        public int GetIntdex_X()
        {
            return index_x;
        }

        public int GetIntdex_Y()
        {
            return index_y;
        }

        public int SetIntdex_X(int index)
        {
            return this.index_x = index;
        }

        public int SetIntdex_Y(int index)
        {
            return this.index_y = index;
        }
    }
}

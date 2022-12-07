using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.core.maze.implementation.Kruskal
{
    class Edge
    {
		private int x;
		private int y;
		private int direction;

		public Edge(int x, int y, int direction)
		{
			this.x = x;
			this.y = y;
			this.direction = direction;
		}

		public int getX() { return x; }
		public int getY() { return y; }
		public int getDirection() { return direction; }
	}
}

namespace MazeGenerator.core.maze.implementation.Kruskal
{
    class Edge
    {
		private readonly int x;
		private readonly int y;
		private readonly int direction;

		public Edge(int x, int y, int direction)
		{
			this.x = x;
			this.y = y;
			this.direction = direction;
		}

		public int GetX() { return x; }
		public int GetY() { return y; }
		public int GetDirection() { return direction; }
	}
}

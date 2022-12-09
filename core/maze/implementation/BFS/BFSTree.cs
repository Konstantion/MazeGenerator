using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.core.maze.implementation.BFS
{
    class BFSTree
    {
        public BFSTree parent = null;
        public Cell cell;

        public BFSTree(Cell cell)
        {
            this.cell = cell;
        }

		public BFSTree Root()
		{
			return parent != null ? parent.Root() : this;
		}


		public bool Connected(BFSTree tree)
		{
			return this.Root() == tree.Root();
		}


		public void Connect(BFSTree tree)
		{
			tree.Root().SetPerent(this);
		}


		public void SetPerent(BFSTree parent)
		{
			this.parent = parent;
		}
	}
}

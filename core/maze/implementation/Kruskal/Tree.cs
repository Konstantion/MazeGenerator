using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.core.maze.implementation.Kruskal
{
    class Tree
    {
		private Tree parent = null;

		public Tree()
		{

		}

		
		public Tree Root()
		{
			return parent != null ? parent.Root() : this;
		}

		
		public bool Connected(Tree tree)
		{
			return this.Root() == tree.Root();
		}

		
		public void Connect(Tree tree)
		{
			tree.Root().SetPerent(this);
		}

		
		public void SetPerent(Tree parent)
		{
			this.parent = parent;
		}
	}
}

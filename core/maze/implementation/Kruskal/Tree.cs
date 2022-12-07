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

		
		public Tree root()
		{
			return parent != null ? parent.root() : this;
		}

		
		public bool connected(Tree tree)
		{
			return this.root() == tree.root();
		}

		
		public void connect(Tree tree)
		{
			tree.root().setParent(this);
		}

		
		public void setParent(Tree parent)
		{
			this.parent = parent;
		}
	}
}

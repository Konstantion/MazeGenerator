using MazeGenerator.core.maze.implementation;
using System.Drawing;
using static MazeGenerator.core.maze.DrawingTools;

namespace MazeGenerator.core.maze
{
    partial class Cell 
    {
        public int val;

        private float x;
        private float y;

        private float size;

        private int index_X;
        private int index_Y;

        private Graphics g;     
        private RectangleF backGround;
       
        public Cell(float size, float x, float y, Graphics g, int val, int index_X, int index_Y)
        {
            this.val = val;

            this.x = x;
            this.y = y;

            this.size = size;

            this.index_X = index_X;
            this.index_Y = index_Y;

            this.g = g;

            backGround = new RectangleF(x + CELL_BORDER / 2f,
                    y+CELL_BORDER/2f,
                    size-CELL_BORDER,
                    size- CELL_BORDER
                );
        }        


        public override string ToString()
        {
            return $"Cell [x : {x}, y : {y}, size: {size}, val : {val}, index x : {X}, index y: {Y}]";
        }

        public int X
        {
            get {
                return index_X;
            }
        }

        public int Y
        {
            get
            {
                return index_Y;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Cell that
                && this.x == that.x
                && this.y == that.y
                && this.val == that.val
                && this.size == that.size
                && this.g == that.g;
        }
    }
}

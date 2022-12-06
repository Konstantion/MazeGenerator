using MazeGenerator.src.maze.implementation;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MazeGenerator.src.maze.DrawingTools;

namespace MazeGenerator.src.maze
{
    class Cell 
    {
        public int val;
        private float x;
        private float y;
        private float size;

        private Graphics g;
     
        private RectangleF backGround;
       
        public Cell(float size, float x, float y, Graphics g, int val)
        {
            this.g = g;          
            this.x = x;
            this.y = y;
            this.size = size;
            this.val = val;

            backGround = new RectangleF(x+ CELL_BORDER/2f, y+CELL_BORDER/2f, size-CELL_BORDER, size- CELL_BORDER);
        }

        public void DrawCell()
        {
            g.FillRectangle(GRAY_BRUSH, backGround);
        }

        public void DrawNorthWall()
        {
            g.DrawLine(BLACK_PEN, x, y, x + size, y);
        }

        public void DrawSouthWall()
        {

        }

        public void DrawEastWall()
        {
            
        }

        public void DrawWesthWall()
        {
            g.DrawLine(BLACK_PEN, x, y, x, y + size);
        }


    }
}

using MazeGenerator.core.maze.implementation;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MazeGenerator.core.maze.DrawingTools;

namespace MazeGenerator.core.maze
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

        public void DrawCell(SolidBrush brush)
        {
            g.FillRectangle(brush, backGround);
        }

        public void DrawCell()
        {
            DrawCell(GRAY_BRUSH);
        }

        public void DrawNorthWall()
        {
            g.DrawLine(BLACK_PEN, x, y, x + size, y);
        }

        public void DrawSouthWall()
        {
            g.DrawLine(BLACK_PEN, x, y + size, x + size, y + size);
        }

        public void DrawEastWall()
        {
            g.DrawLine(BLACK_PEN, x + size, y, x + size, y + size);
        }

        public void DrawWestWall(Pen pen)
        {
            g.DrawLine(pen, x, y, x, y + size);
        }
        public void DrawWestWall()
        {
            DrawWestWall(BLACK_PEN);
        }

        public void EraseNorthWall(Pen pen)
        {
            g.DrawLine(pen, x + CELL_INDENT, y, x + size - CELL_INDENT, y);
        }
        public void EraseNorthWall()
        {
            EraseNorthWall(WHITE_PEN);
        }

        public void EraseSouthWall(Pen pen)
        {
            g.DrawLine(pen, x + CELL_INDENT, y + size, x + size - CELL_INDENT, y + size);
        }
        public void EraseSouthWall()
        {
            EraseSouthWall(WHITE_PEN);
        }

        public void EraseEastWall(Pen pen)
        {
            g.DrawLine(pen, x + size, y + CELL_INDENT, x + size, y + size - CELL_INDENT);
        }
        public void EraseEastWall()
        {
            EraseEastWall(WHITE_PEN);
        }

        public void EraseWestWall(Pen pen)
        {
            g.DrawLine(pen, x, y + CELL_INDENT, x, y + size - CELL_INDENT);
        }
        public void EraseWestWall()
        {
            EraseWestWall(WHITE_PEN);
        }

    }
}

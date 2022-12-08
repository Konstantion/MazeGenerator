using MazeGenerator.core.maze.implementation;
using System.Drawing;
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

        //Draw North wall
        private void DrawNorthWall(Pen pen)
        {
            g.DrawLine(pen, x, y, x + size, y);
        }

        public void DrawNorthWall()
        {
            DrawNorthWall(BLACK_PEN);
        }

        //Draw South wall
        public void DrawSouthWall(Pen pen)
        {
            g.DrawLine(pen, x, y + size, x + size, y + size);
        }

        public void DrawSouthWall()
        {
            DrawSouthWall(WHITE_PEN);
        }

        //Draw East wall
        public void DrawEastWall(Pen pen)
        {
            g.DrawLine(pen, x + size, y, x + size, y + size);
        }

        public void DrawEastWall()
        {
            DrawEastWall(BLACK_PEN);
        }

        //Draw West wall
        public void DrawWestWall(Pen pen)
        {
            g.DrawLine(pen, x, y, x, y + size);
        }

        public void DrawWestWall()
        {
            DrawWestWall(BLACK_PEN);
        }

        //Erase Notrh wall
        private void EraseNorthWall(Pen pen)
        {
            g.DrawLine(pen, x + CELL_INDENT, y, x + size - CELL_INDENT, y);
        }

        public void EraseNorthWall()
        {
            EraseNorthWall(WHITE_PEN);
        }

        //Erase South wall
        private void EraseSouthWall(Pen pen)
        {
            g.DrawLine(pen, x + CELL_INDENT, y + size, x + size - CELL_INDENT, y + size);
        }

        public void EraseSouthWall()
        {
            EraseSouthWall(WHITE_PEN);
        }

        //Erase East wall
        private void EraseEastWall(Pen pen)
        {
            g.DrawLine(pen, x + size, y + CELL_INDENT, x + size, y + size - CELL_INDENT);
        }

        public void EraseEastWall()
        {
            EraseEastWall(WHITE_PEN);
        }

        //Erase West wall
        private void EraseWestWall(Pen pen)
        {
            g.DrawLine(pen, x, y + CELL_INDENT, x, y + size - CELL_INDENT);
        }
        public void EraseWestWall()
        {
            EraseWestWall(WHITE_PEN);
        }

        public void EraseWall(int DIRECTION, Pen pen)
        {
            switch (DIRECTION)
            {
                case Maze.S:
                    EraseSouthWall(pen);
                    return;
                case Maze.N:
                    EraseNorthWall(pen);
                    return;
                case Maze.W:
                    EraseWestWall(pen);
                    return;
                case Maze.E:
                    EraseEastWall(pen);
                    return;
            }
        }

        public void DrawWall(int DIRECTION, Pen pen)
        {
            switch (DIRECTION)
            {
                case Maze.S:
                    DrawSouthWall(pen);
                    return;
                case Maze.N:
                    DrawNorthWall(pen);
                    return;
                case Maze.W:
                    DrawWestWall(pen);
                    return;
                case Maze.E:
                    DrawEastWall(pen);
                    return;
            }
        }

    }
}

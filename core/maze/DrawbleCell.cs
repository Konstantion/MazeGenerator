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
    partial class Cell
    {
        public void DrawCell(SolidBrush brush)
        {
            g.FillRectangle(brush, backGround);
        }

        public void DrawCell()
        {
            DrawCell(GRAY_BRUSH);
        }

        public void DrawFullCell(SolidBrush brush)
        {
            RectangleF fullBackGround = new RectangleF(x, y, size, size);
            g.FillRectangle(brush, fullBackGround);
        }

        /// <summary>
        /// Draw North wall of the Cell using given pen
        /// </summary>
        /// <param name="pen"></param>
        private void DrawNorthWall(Pen pen)
        {
            g.DrawLine(pen, x, y, x + size, y);
        }       

        /// <summary>
        /// Draw South wall of the Cell using given pen
        /// </summary>
        /// <param name="pen"></param>
        public void DrawSouthWall(Pen pen)
        {
            g.DrawLine(pen, x, y + size, x + size, y + size);
        }       

        /// <summary>
        /// Draw East wall of the Cell using given pen
        /// </summary>
        /// <param name="pen"></param>
        public void DrawEastWall(Pen pen)
        {
            g.DrawLine(pen, x + size, y, x + size, y + size);
        }       

        /// <summary>
        /// Draw West wall of the Cell using given pen
        /// </summary>
        /// <param name="pen"></param>
        public void DrawWestWall(Pen pen)
        {
            g.DrawLine(pen, x, y, x, y + size);
        }

        /// <summary>
        /// Erase North wall of the Cell using given pen
        /// </summary>
        /// <param name="pen"></param>
        private void EraseNorthWall(Pen pen)
        {
            g.DrawLine(pen, x + CELL_INDENT, y, x + size - CELL_INDENT, y);
        }

        /// <summary>
        /// Erase South wall of the Cell using given pen
        /// </summary>
        /// <param name="pen"></param>
        private void EraseSouthWall(Pen pen)
        {
            g.DrawLine(pen, x + CELL_INDENT, y + size, x + size - CELL_INDENT, y + size);
        }

        /// <summary>
        /// Erase East wall of the Cell using given pen
        /// </summary>
        /// <param name="pen"></param>
        private void EraseEastWall(Pen pen)
        {
            g.DrawLine(pen, x + size, y + CELL_INDENT, x + size, y + size - CELL_INDENT);
        }

        /// <summary>
        /// Erase West wall of the Cell using given pen
        /// </summary>
        /// <param name="pen"></param>
        private void EraseWestWall(Pen pen)
        {
            g.DrawLine(pen, x, y + CELL_INDENT, x, y + size - CELL_INDENT);
        }

        /// <summary>
        /// Erase wall of the Cell by given direction using given pen
        /// </summary>
        /// <param name="pen"></param>
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

        /// <summary>
        /// Draw wall of the Cell using given direction using given pen
        /// </summary>
        /// <param name="pen"></param>
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

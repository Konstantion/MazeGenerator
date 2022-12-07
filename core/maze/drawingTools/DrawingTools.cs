﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.src.maze
{
    
    static class DrawingTools
    {
        public static readonly int CELL_BORDER = 2;
        public static readonly int CELL_INDENT = CELL_BORDER / 2;
        public static readonly Pen WHITE_PEN = new Pen(Color.White, CELL_BORDER);
        public static readonly Pen BLACK_PEN = new Pen(Color.Black, CELL_BORDER);
        public static readonly SolidBrush BLACK_BRUSH = new SolidBrush(Color.Black);
        public static readonly SolidBrush WHITE_BRUSH = new SolidBrush(Color.White);
        public static readonly SolidBrush GRAY_BRUSH = new SolidBrush(Color.Gray);
        public static readonly SolidBrush RED_BRUSH = new SolidBrush(Color.Red);


    }
}

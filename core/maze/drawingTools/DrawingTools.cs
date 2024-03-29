﻿using System.Drawing;

namespace MazeGenerator.core.maze
{
    class DrawingTools
    {
        public static readonly int CELL_BORDER = 2;
        public static readonly int CELL_INDENT = CELL_BORDER / 2;
        public static readonly Pen WHITE_PEN = new Pen(Color.White, CELL_BORDER);
        public static readonly Pen BLACK_PEN = new Pen(Color.Black, CELL_BORDER);
        public static readonly SolidBrush BLACK_BRUSH = new SolidBrush(Color.Black);
        public static readonly SolidBrush WHITE_BRUSH = new SolidBrush(Color.White);
        public static readonly SolidBrush GRAY_BRUSH = new SolidBrush(Color.Gray);
        public static readonly SolidBrush RED_BRUSH = new SolidBrush(Color.Red);
        public static readonly SolidBrush YELLOW_BRUSH = new SolidBrush(Color.Yellow);
        public static readonly SolidBrush BLUE_BRUSH = new SolidBrush(Color.Blue);
        public static readonly SolidBrush LIGHT_BLUE_BRUSH = new SolidBrush(Color.LightBlue);
        public static readonly SolidBrush DARK_BLUE_BRUSH = new SolidBrush(Color.DarkBlue);
        public static readonly SolidBrush GREEN_BRUSH = new SolidBrush(Color.Green);
        public static readonly SolidBrush AQUAMARINE_BRUSH = new SolidBrush(Color.Aquamarine);
    }
}

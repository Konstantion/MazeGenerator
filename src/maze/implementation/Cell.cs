using MazeGenerator.src.maze.implementation;
using MazeGenerator.src.maze.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MazeGenerator.src.maze.DrawingTools;

namespace MazeGenerator.src.maze
{
    class Cell : IMazeElement
    {
        public Wall TopWall;
        public Wall BottomWall;
        public Wall RightWall;
        public Wall LeftWall;
        public List<Wall> walls = new List<Wall>();

        private float x;
        private float y;
        private float size;

        private Graphics g;
     
        private RectangleF backGround;
       
        public Cell(float size, float x, float y, Graphics g)
        {
            this.g = g;          
            this.x = x;
            this.y = y;
            this.size = size;
            



            TopWall = new Wall(size,x,y,x+size,y,g);
            BottomWall = new Wall(size,x,y+size,x+size, y + size, g);
            RightWall = new Wall(size,x,y,x,y+size, g);
            LeftWall = new Wall(size,x+size,y,x+size,y+size, g);

            walls.Add(TopWall);
            walls.Add(BottomWall);
            walls.Add(RightWall);
            walls.Add(LeftWall);

            backGround = new RectangleF(x+ CELL_BORDER/2f, y+CELL_BORDER/2f, size-CELL_BORDER, size- CELL_BORDER);
        }

        public void Draw()
        {
            FillGray();
            walls.ForEach(w => w.Draw());
           
        }

        public void FillBlack()
        {
            g.FillRectangle(BLACK_BRUSH, backGround);
        }
        public void FillWhite()
        {
            g.FillRectangle(WHITE_BRUSH, backGround);
        }

        public void FillGray()
        {
            g.FillRectangle(GRAY_BRUSH, backGround);
        }

        public void FillRed()
        {
            g.FillRectangle(RED_BRUSH, backGround);
        }
    }
}

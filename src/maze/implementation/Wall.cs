using MazeGenerator.src.maze.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MazeGenerator.src.maze.DrawingTools;

namespace MazeGenerator.src.maze.implementation
{
    class Wall : IMazeElement
    {
        private float size;
        

        private Graphics g;
        private PointF pointStart;
        private PointF pointEnd;


        public Wall(float size, float x1, float y1, float x2, float y2, Graphics g)
        {
            this.size = size;
            this.pointStart = new PointF(x1, y1);
            this.pointEnd = new PointF(x2, y2);
            this.g = g;
          
        }

        public void Draw()
        {
            g.DrawLine(BLACK_PEN, pointStart,pointEnd);
        }

        public void FillBlack()
        {
            g.DrawLine(BLACK_PEN, pointStart, pointEnd);
        }

        public void FillGray()
        {
            throw new NotImplementedException();
        }

        public void FillRed()
        {
            throw new NotImplementedException();
        }

        public void FillWhite()
        {
            g.DrawLine(WHITE_PEN, pointStart, pointEnd);
        }
    }
}

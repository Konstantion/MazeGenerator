using MazeGenerator.src.maze.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.src.maze.implementation
{
    class Maze : IMazeElement
    {
        public Cell[,] cells;

        private int size;


        private Graphics g;
    

        public Maze(int n, int size, Graphics g)
        {
            this.g = g;
            this.size = size;
           
            float cellSize =(float) (size*1.0) / n;
            cells = new Cell[n, n];
            for(int i = 0; i <n; i++)
            {
                float y = i * cellSize;
                for (int j = 0; j < n; j++)
                {
                    float x = j * cellSize;
                    cells[i, j] = new Cell(cellSize, x, y, g);
                }
            }
        }

        public void Draw()
        {
            g.Clear(Color.White);
            foreach (Cell cell in cells)
            {
                cell.Draw();
            }
        }

        public void FillBlack()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

    }
}

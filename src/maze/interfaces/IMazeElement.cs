using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.src.maze.interfaces
{
    interface IMazeElement
    {
        void Draw();
        void FillBlack();
        void FillWhite();
        void FillGray();
        void FillRed();
    }
}

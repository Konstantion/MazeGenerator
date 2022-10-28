using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.src.algorithms
{
    class AlgorithmComboItem
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public AlgorithmComboItem(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}

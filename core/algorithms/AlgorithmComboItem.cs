using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.core.algorithms
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

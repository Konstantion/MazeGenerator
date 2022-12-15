using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.core.algorithms
{
    class ComboItem
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public ComboItem(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
}

using MazeGenerator.src.algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGenerator
{

    public partial class Form1 : Form
    {
       
        public Form1()
        {            
            InitializeComponent();
            SetAlgorithmComboBoxData();
           
        }
        private void SetAlgorithmComboBoxData()
        {
            this.comboBoxAlgorithm.DataSource = new AlgorithmComboItem[]
           {
                new AlgorithmComboItem("Kruskal's Algorithm",1),
                new AlgorithmComboItem("Prim's Algorithm",2)
           };
            this.comboBoxAlgorithm.DisplayMember = "Name";
            this.comboBoxAlgorithm.ValueMember = "Id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day12_GUI
{
    public partial class Form1 : Form
    {
        int Reizes;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            
            label1.Text = "Sveiks, " + textBox1.Text + "!";
            Reizes++;
            label2.Text = "Poga nospiesta " + Reizes + " reizes";
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

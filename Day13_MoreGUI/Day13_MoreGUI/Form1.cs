using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day13_MoreGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string filename = "Saraksts.txt";

            List<string> Saraksts = new List<String>();
            
            FailaDarbibas.WriteStringLst(Saraksts, filename);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                ListElements.Items.Add(textBox1.Text);
            }
            
        }

        private void ListElements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

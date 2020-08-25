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
        string filename = "Saraksts.txt";

        public Form1()
        {
            InitializeComponent();

            List<string> Saraksts = new List<String>();
            
          //  FailaDarbibas.WriteStringLst(Saraksts, filename);
            FailaDarbibas.ReadStringLst(filename);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ElementList.Items.Add(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ElementList.SelectedItems.Count; i++)
            {
                ElementList.Items.Remove(ElementList.SelectedItems[i]);
                i--;
            }
        }
    }
}

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

            List<String> Saraksts = FailaDarbibas.ReadList(filename);
            foreach (String Rindinja in Saraksts)
            {
                ElementList.Items.Add(Rindinja);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ElementList.Items.Add(textBox1.Text);
            }
            UpdeitojamaisFails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Dazaadi veidi ka izdzest elementus
            Delete1();
            Delete2();
           // Delete3(); Bugaina metode
            UpdeitojamaisFails();
        }
        private void UpdeitojamaisFails()
        {
            FailaDarbibas.WriteList(ElementList, filename);
        }

        private void Delete3()
        {
            // izdzes pedejo ievietoto rindinu, ja nekas nav selekteets
            if (ElementList.SelectedItems.Count == 0)
            {
                ElementList.Items.RemoveAt(ElementList.Items.Count - 1);
                return;
            }
        }

        private void Delete2()
        {
            // Dzes selektetos itemus
            for (int i = 0; i < ElementList.SelectedItems.Count; i++)
            {
                ElementList.Items.Remove(ElementList.SelectedItems[i]);
                i--;
            }
        }

        private void Delete1()
        {
            foreach (ListViewItem item in ElementList.SelectedItems)
            {
                item.Remove();
            }
        }
       
    }
}

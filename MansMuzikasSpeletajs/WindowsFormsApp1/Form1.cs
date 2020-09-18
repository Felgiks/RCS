using AxWMPLib;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MusicPlayerApp : Form
    {
        String[] paths;
        String[] files;
        int Reizes;
        int Minejums;
        int PareizaisNumurs;
        bool Virziens = true;
        Point lastPoint;

        public MusicPlayerApp()
        {
            InitializeComponent();
        }
        private void labelLOGO_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Brīva vieta jūsu reklamai - www.felgiks.com");
        }
        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                if (ListBoxSongs.Items.Count > 0)
                {
                    for (int i = ListBoxSongs.Items.Count; i < (files.Length + ListBoxSongs.Items.Count); i++)
                    {
                        ListBoxSongs.Items.Add(files[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        ListBoxSongs.Items.Add(files[i]);
                    }
                }
            }
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            WMPMusic.URL = paths[ListBoxSongs.SelectedIndex];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            Reizes++;
            Daritaajs(Reizes);
        }

        private void Daritaajs(int reizes)
        {
            if (reizes == 1)
            {
                textBox1.BackColor = Color.White;
                label2.BackColor = Color.White;
                Poga1.Text = "Yep,thats my name!";
                label2.Text = "Ka tevi sauc?";
            }
            if (reizes == 2)
            {
                label2.Text = "Sveiki " + textBox1.Text + ", uzspelesim so speli...";
                label3.BackColor = Color.White;
                label3.Text = "Tev bus jauzmin mans iedomatais skaitlis!";
                Poga1.Text = "Ja, es esmu gatavs!";
            }
            if (Reizes == 3)
            {
                Random Randoms = new Random();
                PareizaisNumurs = Randoms.Next(1, 10);
                label3.Text = "Uzmini manu skaitli no 1 lidz 10!";
                Poga1.Text = "Iesniegt!";
                textBox1.Text = String.Empty;
            }
            if (Reizes > 3 && Reizes < 100)
            {
                Minetajs(textBox1.Text);
            }
            if (Reizes == 100)
            {
                if (textBox1.Text.ToUpper() == "N")
                {
                    Reizes = 0;
                    textBox1.BackColor = Color.Black;
                    label2.BackColor = Color.Black;
                    label3.BackColor = Color.Black;
                    Poga1.Text = "Do you want to play a game? ";
                }
                else if (textBox1.Text.ToUpper() == "Y")
                {
                    Reizes = 2;
                }
                else
                {
                    Reizes = 2;
                }
            }
        }

        private void Minetajs(string ievade)
        {
            if (!int.TryParse(ievade, out Minejums))
            {
                label3.Text = "Ludzu, ievadi skaitli, nevis ko citu!";
            }
            else if (ievade == "")
            {
                label3.Text = "Ludzu, ievadi skaitli, nevis ko citu!";
            }
            else if (Minejums != PareizaisNumurs)
            {
                Minejums = Int32.Parse(ievade);
                if (Minejums != PareizaisNumurs)
                {
                    if (Virziens == true)
                    {
                        label3.Text = "Skaitlis nepareizs, megini velreiz!";
                    }
                    if (Virziens == false)
                    {
                        label3.Text = "Skaitlis tomer nepareizs, megini velreiz!";
                    }
                    Virziens = !Virziens;
                }
                else
                {
                    label3.Text = "Ludzu, ievadi skaitli, nevis ko citu!";
                }
            }
            else if (Minejums == PareizaisNumurs)
            {
                label3.Text = "Tu uzmineji manu skaitli! Minesi velreiz? [Y or N]";
                Reizes = 99;
            }
        }

        private void TopPanelis_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void TopPanelis_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void TopPanelis_Paint(object sender, PaintEventArgs e)
        {
           // lastPoint = new Point(e.X, e.Y);
        }
    }
}

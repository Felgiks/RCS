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
        String[] paths, files;
       
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        private void labelLOGO_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Brīva vieta jūsu majaslapai - felgiks.com");
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //int ArrayIndex = ListBoxSongs.Items.Count;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                if (ListBoxSongs.Items.Count > 0)
                {
                    for (int i = ListBoxSongs.Items.Count; i < files.Length; i++)
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
    }
}

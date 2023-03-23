using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusciPlayerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] paths, files;

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[list.SelectedIndex];
        }

        private void player_Enter(object sender, EventArgs e)
        {
            
        }

        private void select_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int i=0;i<files.Length;i++)
                {
                    list.Items.Add(files[i]);
                }
            }
        }
    }
}

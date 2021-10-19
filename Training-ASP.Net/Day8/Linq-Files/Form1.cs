using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Linq_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Files_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\vgikku\\OneDrive - SOTI Inc\\Training-DotNet\\Day8");
            var files = (from a in dir.GetFiles() select a).ToList();
            grd_Grid.DataSource = files;
            var filescount = (from a in dir.GetFiles() select a).Count();
            lbl_Filecount.Text = filescount.ToString();

        }

        private void btn_Folders_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\vgikku\\OneDrive - SOTI Inc\\Training-DotNet\\Day8");
            var folders = (from a in dir.GetDirectories() select a).ToList();
            grd_Grid.DataSource = folders;
        }
    }
}

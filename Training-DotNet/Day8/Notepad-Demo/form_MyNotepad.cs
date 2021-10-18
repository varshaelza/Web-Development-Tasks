using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Notepad_Demo
{
    public partial class form_notepad : Form
    {
        public form_notepad()
        {
            InitializeComponent();
        }

        private void abotToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            FileStream myFile = new FileStream(saveFileDialog1.FileName + ".txt", FileMode.Create, FileAccess.Write);
            StreamWriter wr = new StreamWriter(myFile);
            wr.WriteLine(richTextBox1.Text);
            wr.Close();


        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;

        }

        private void changeBackkgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileStream myFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            StreamReader rd = new StreamReader(myFile);
            richTextBox1.Text = rd.ReadToEnd();
            rd.Close();
            myFile.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            FileStream myFile = new FileStream(saveFileDialog1.FileName + ".pdf", FileMode.Create, FileAccess.Write);
            StreamWriter wr = new StreamWriter(myFile);
            wr.WriteLine(richTextBox1.Text);
            wr.Close();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;

        }

        private void aboutMyNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}

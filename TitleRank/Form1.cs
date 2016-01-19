using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitleRank
{
    public partial class Form1 : Form
    {
        private char seperator = ',';

        public Form1()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            //open files (1 read 1 write)

            //process and output lines to output file, errors recorded in output textbox
            
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //copy filename into textbox
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //copy filename to textbox
        }

        private void setInputFilenameButton_Click(object sender, EventArgs e)
        {
            //open the openfiledialog
        }

        private void setOutputFilenameButton_Click(object sender, EventArgs e)
        {
            //open the savefiledialog
        }
    }
}

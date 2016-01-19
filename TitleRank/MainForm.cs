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
    public partial class MainForm : Form
    {
        private char separator = ',';

        public MainForm()
        {
            InitializeComponent();
            separationCharacterTextbox.Text = separator.ToString();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            outputTextBox.ResetText();
            if(!File.Exists(inputFilenameTextbox.Text))
            {
                appendTextToUserLog("Input file does not exist. Aborting...");
            }

            if (File.Exists(outputFilenameTextbox.Text))
            {
                //show warning - if no to overwrite then open savefiledialog??
                var confirmation = MessageBox.Show("This file already exists and will be overwritten." + Environment.NewLine + "Are you sure you want to do this?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirmation != DialogResult.OK)
                {
                    outputFilenameTextbox.Text = string.Empty;
                    appendTextToUserLog("Output file already exists. User abort to prevent overwriting...");
                    return;
                }
            }
        

            //open files (1 read 1 write)
            FileStream inputfileStream = File.OpenRead(inputFilenameTextbox.Text);
            FileStream outputfileStream;
            if(appendToFileCheckbox.Checked)
            {
                outputfileStream = File.Open(outputFilenameTextbox.Text, FileMode.Append, FileAccess.Write);
            }
            else
            {
                outputfileStream = File.Open(outputFilenameTextbox.Text, FileMode.Create, FileAccess.Write);
            }

            //process and output lines to output file, errors recorded in output textbox (and continue on)

            //track maximum number of ranks found
            //track line number for error reporting

            if(ignoreFirstLineCheckbox.Checked)
            {
                //read first line and ignore it
            }

            //write header to output (not with ranks yet.. those are added a the end)

            //while not end of file read a line, process it, save the result

            //return to first line of output and write out the header with the longest rank
            
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //copy filename into textbox
            inputFilenameTextbox.Text = openFileDialog.FileName;
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //copy filename to textbox
            outputFilenameTextbox.Text = saveFileDialog.FileName;
        }

        private void setInputFilenameButton_Click(object sender, EventArgs e)
        {
            //open the openfiledialog
            openFileDialog.ShowDialog();
        }

        private void setOutputFilenameButton_Click(object sender, EventArgs e)
        {
            //open the savefiledialog
            saveFileDialog.ShowDialog();
        }

        private void inputFilenameTextbox_Leave(object sender, EventArgs e)
        {
            if (File.Exists(inputFilenameTextbox.Text))
            {
                //check if file exists (set openfiledialog)
                openFileDialog.FileName = inputFilenameTextbox.Text;
            }
        }

        private void outputFilenameTextbox_Leave(object sender, EventArgs e)
        {
            saveFileDialog.FileName = outputFilenameTextbox.Text;
        }

        private void separationCharacterTextbox_TextChanged(object sender, EventArgs e)
        {
            //update separation character
            separator = separationCharacterTextbox.Text[0];
        }

        private void appendTextToUserLog(string text)
        {
            outputTextBox.AppendText(text);
            outputTextBox.AppendText(Environment.NewLine);
        }
    }
}

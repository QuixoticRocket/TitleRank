﻿using System;
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
            //open files (1 read 1 write)

            //process and output lines to output file, errors recorded in output textbox
            
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
            if(File.Exists(outputFilenameTextbox.Text))
            {
                //show warning - if no to overwrite then open savefiledialog??
                var confirmation = MessageBox.Show("This file already exists and will be overwritten." + Environment.NewLine + "Are you sure you want to do this?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(confirmation != DialogResult.OK)
                {
                    outputFilenameTextbox.Text = string.Empty;
                    saveFileDialog.ShowDialog();
                    return;
                }
            }
            saveFileDialog.FileName = outputFilenameTextbox.Text;
        }

        private void separationCharacterTextbox_TextChanged(object sender, EventArgs e)
        {
            //update separation character
            separator = separationCharacterTextbox.Text[0];
        }
    }
}
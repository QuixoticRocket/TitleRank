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
            if (!File.Exists(inputFilenameTextbox.Text))
            {
                Shared.appendTextToTextbox("Input file does not exist. Aborting...", outputTextBox);
            }

            if (!appendToFileCheckbox.Checked && File.Exists(outputFilenameTextbox.Text))
            {
                //show warning - if no to overwrite then open savefiledialog??
                var confirmation = MessageBox.Show("This file already exists and will be overwritten." + Environment.NewLine + "Are you sure you want to do this?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (confirmation != DialogResult.OK)
                {
                    outputFilenameTextbox.Text = string.Empty;
                    Shared.appendTextToTextbox("Output file already exists. User abort to prevent overwriting...", outputTextBox);
                    return;
                }
            }

            //open read file
            FileStream inputfileStream;
            try
            {
                inputfileStream = File.OpenRead(inputFilenameTextbox.Text);
            }
            catch (Exception ex)
            {
                Shared.appendTextToTextbox("Exception opening file to read." + Environment.NewLine + "Exception Message: " + ex.Message, outputTextBox);
                return;
            }

            RowProcessor processor = new RowProcessor();
            List<TitleRankNode> nodes = processor.CreateGraphsFromInput(inputfileStream, ignoreFirstLineCheckbox.Checked, separator, ref outputTextBox);

            if (inputfileStream != null)
            {
                inputfileStream.Dispose();
            }

            //write data to file
            nodes = nodes.OrderBy(n => n.Id).ToList();

            //open write file
            FileStream outputfileStream;
            try
            {
                if (appendToFileCheckbox.Checked)
                {
                    outputfileStream = File.Open(outputFilenameTextbox.Text, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    outputfileStream = File.Open(outputFilenameTextbox.Text, FileMode.Create, FileAccess.Write);
                }
            }
            catch (Exception ex)
            {
                Shared.appendTextToTextbox("Exception opening output file." + Environment.NewLine + "Exception Message: " + ex.Message, outputTextBox);
                return;
            }
            StreamWriter writer = new StreamWriter(outputfileStream);

            int maxlevel = nodes.Select(x => x.Level).Max();
            StringBuilder sb = new StringBuilder();

            //header
            sb.Append(Shared.IdHeading);
            sb.Append(separator);
            //levels
            for (int i = 1; i <= maxlevel; i++)
            {
                sb.Append(Shared.LevelPartialHeading + i.ToString());
                sb.Append(separator);
            }
            sb.Append(Shared.CurrentUrlHeading);
            sb.Append(separator);

            writer.WriteLine(sb.ToString());
            sb.Clear();

            //for each node
            foreach (var node in nodes)
            {
                sb.Append(node.Id);
                sb.Append(separator);
                //levels
                for (int i = 1; i <= maxlevel; i++)
                {
                    if (i == node.Level)
                    {
                        sb.Append(node.Title);
                    }
                    sb.Append(separator);
                }
                sb.Append(node.Url);
                sb.Append(separator);

                writer.WriteLine(sb.ToString());
                sb.Clear();
            }

            //close file stream
            writer.Close();
            if (writer != null)
            {
                writer.Dispose();
            }

            Shared.appendTextToTextbox("- - - Done - - - ", outputTextBox);
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
    }
}

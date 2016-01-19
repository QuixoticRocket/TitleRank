namespace TitleRank
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.inputFileNameLabel = new System.Windows.Forms.Label();
            this.inputFilenameTextbox = new System.Windows.Forms.TextBox();
            this.setInputFilenameButton = new System.Windows.Forms.Button();
            this.setOutputFilenameButton = new System.Windows.Forms.Button();
            this.outputFilenameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ignoreFirstLineCheckbox = new System.Windows.Forms.CheckBox();
            this.separationCharacterTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.appendToFileCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(10, 102);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(507, 151);
            this.outputTextBox.TabIndex = 999;
            this.outputTextBox.TabStop = false;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(9, 79);
            this.processButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(506, 19);
            this.processButton.TabIndex = 6;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // inputFileNameLabel
            // 
            this.inputFileNameLabel.AutoSize = true;
            this.inputFileNameLabel.Location = new System.Drawing.Point(10, 13);
            this.inputFileNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputFileNameLabel.Name = "inputFileNameLabel";
            this.inputFileNameLabel.Size = new System.Drawing.Size(53, 13);
            this.inputFileNameLabel.TabIndex = 999;
            this.inputFileNameLabel.Text = "Input File:";
            // 
            // inputFilenameTextbox
            // 
            this.inputFilenameTextbox.Location = new System.Drawing.Point(76, 11);
            this.inputFilenameTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputFilenameTextbox.Name = "inputFilenameTextbox";
            this.inputFilenameTextbox.Size = new System.Drawing.Size(384, 20);
            this.inputFilenameTextbox.TabIndex = 0;
            this.inputFilenameTextbox.Leave += new System.EventHandler(this.inputFilenameTextbox_Leave);
            // 
            // setInputFilenameButton
            // 
            this.setInputFilenameButton.Location = new System.Drawing.Point(464, 10);
            this.setInputFilenameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.setInputFilenameButton.Name = "setInputFilenameButton";
            this.setInputFilenameButton.Size = new System.Drawing.Size(52, 19);
            this.setInputFilenameButton.TabIndex = 1;
            this.setInputFilenameButton.Text = "...";
            this.setInputFilenameButton.UseVisualStyleBackColor = true;
            this.setInputFilenameButton.Click += new System.EventHandler(this.setInputFilenameButton_Click);
            // 
            // setOutputFilenameButton
            // 
            this.setOutputFilenameButton.Location = new System.Drawing.Point(464, 32);
            this.setOutputFilenameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.setOutputFilenameButton.Name = "setOutputFilenameButton";
            this.setOutputFilenameButton.Size = new System.Drawing.Size(52, 19);
            this.setOutputFilenameButton.TabIndex = 3;
            this.setOutputFilenameButton.Text = "...";
            this.setOutputFilenameButton.UseVisualStyleBackColor = true;
            this.setOutputFilenameButton.Click += new System.EventHandler(this.setOutputFilenameButton_Click);
            // 
            // outputFilenameTextbox
            // 
            this.outputFilenameTextbox.Location = new System.Drawing.Point(76, 33);
            this.outputFilenameTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputFilenameTextbox.Name = "outputFilenameTextbox";
            this.outputFilenameTextbox.Size = new System.Drawing.Size(384, 20);
            this.outputFilenameTextbox.TabIndex = 2;
            this.outputFilenameTextbox.Leave += new System.EventHandler(this.outputFilenameTextbox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 999;
            this.label1.Text = "Output File:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Comma Separated Value (*.csv)|*.csv|All Files (*.*)|*.*";
            this.openFileDialog.Title = "Open File";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Comma Separated Value (*.csv)|*.csv|All Files (*.*)|*.*";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // ignoreFirstLineCheckbox
            // 
            this.ignoreFirstLineCheckbox.AutoSize = true;
            this.ignoreFirstLineCheckbox.Checked = true;
            this.ignoreFirstLineCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreFirstLineCheckbox.Location = new System.Drawing.Point(13, 58);
            this.ignoreFirstLineCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ignoreFirstLineCheckbox.Name = "ignoreFirstLineCheckbox";
            this.ignoreFirstLineCheckbox.Size = new System.Drawing.Size(138, 17);
            this.ignoreFirstLineCheckbox.TabIndex = 4;
            this.ignoreFirstLineCheckbox.Text = "Ignore first line of input?";
            this.ignoreFirstLineCheckbox.UseVisualStyleBackColor = true;
            // 
            // separationCharacterTextbox
            // 
            this.separationCharacterTextbox.AcceptsTab = true;
            this.separationCharacterTextbox.Location = new System.Drawing.Point(440, 55);
            this.separationCharacterTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.separationCharacterTextbox.MaxLength = 1;
            this.separationCharacterTextbox.Name = "separationCharacterTextbox";
            this.separationCharacterTextbox.Size = new System.Drawing.Size(76, 20);
            this.separationCharacterTextbox.TabIndex = 5;
            this.separationCharacterTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.separationCharacterTextbox.TextChanged += new System.EventHandler(this.separationCharacterTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1002;
            this.label2.Text = "Separation Character:";
            // 
            // appendToFileCheckbox
            // 
            this.appendToFileCheckbox.AutoSize = true;
            this.appendToFileCheckbox.Location = new System.Drawing.Point(173, 58);
            this.appendToFileCheckbox.Name = "appendToFileCheckbox";
            this.appendToFileCheckbox.Size = new System.Drawing.Size(130, 17);
            this.appendToFileCheckbox.TabIndex = 4;
            this.appendToFileCheckbox.Text = "Append to output file?";
            this.appendToFileCheckbox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 269);
            this.Controls.Add(this.appendToFileCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.separationCharacterTextbox);
            this.Controls.Add(this.ignoreFirstLineCheckbox);
            this.Controls.Add(this.setOutputFilenameButton);
            this.Controls.Add(this.outputFilenameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setInputFilenameButton);
            this.Controls.Add(this.inputFilenameTextbox);
            this.Controls.Add(this.inputFileNameLabel);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.outputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(542, 308);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(542, 308);
            this.Name = "MainForm";
            this.Text = "Title Rank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label inputFileNameLabel;
        private System.Windows.Forms.TextBox inputFilenameTextbox;
        private System.Windows.Forms.Button setInputFilenameButton;
        private System.Windows.Forms.Button setOutputFilenameButton;
        private System.Windows.Forms.TextBox outputFilenameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.CheckBox ignoreFirstLineCheckbox;
        private System.Windows.Forms.TextBox separationCharacterTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox appendToFileCheckbox;
    }
}


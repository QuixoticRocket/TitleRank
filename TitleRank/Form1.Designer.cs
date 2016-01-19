namespace TitleRank
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(13, 98);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(675, 213);
            this.outputTextBox.TabIndex = 999;
            this.outputTextBox.TabStop = false;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(12, 69);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(675, 23);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // inputFileNameLabel
            // 
            this.inputFileNameLabel.AutoSize = true;
            this.inputFileNameLabel.Location = new System.Drawing.Point(14, 16);
            this.inputFileNameLabel.Name = "inputFileNameLabel";
            this.inputFileNameLabel.Size = new System.Drawing.Size(69, 17);
            this.inputFileNameLabel.TabIndex = 999;
            this.inputFileNameLabel.Text = "Input File:";
            // 
            // inputFilenameTextbox
            // 
            this.inputFilenameTextbox.Location = new System.Drawing.Point(101, 13);
            this.inputFilenameTextbox.Name = "inputFilenameTextbox";
            this.inputFilenameTextbox.Size = new System.Drawing.Size(511, 22);
            this.inputFilenameTextbox.TabIndex = 0;
            // 
            // setInputFilenameButton
            // 
            this.setInputFilenameButton.Location = new System.Drawing.Point(619, 12);
            this.setInputFilenameButton.Name = "setInputFilenameButton";
            this.setInputFilenameButton.Size = new System.Drawing.Size(69, 23);
            this.setInputFilenameButton.TabIndex = 1;
            this.setInputFilenameButton.Text = "...";
            this.setInputFilenameButton.UseVisualStyleBackColor = true;
            this.setInputFilenameButton.Click += new System.EventHandler(this.setInputFilenameButton_Click);
            // 
            // setOutputFilenameButton
            // 
            this.setOutputFilenameButton.Location = new System.Drawing.Point(618, 40);
            this.setOutputFilenameButton.Name = "setOutputFilenameButton";
            this.setOutputFilenameButton.Size = new System.Drawing.Size(69, 23);
            this.setOutputFilenameButton.TabIndex = 3;
            this.setOutputFilenameButton.Text = "...";
            this.setOutputFilenameButton.UseVisualStyleBackColor = true;
            this.setOutputFilenameButton.Click += new System.EventHandler(this.setOutputFilenameButton_Click);
            // 
            // outputFilenameTextbox
            // 
            this.outputFilenameTextbox.Location = new System.Drawing.Point(101, 41);
            this.outputFilenameTextbox.Name = "outputFilenameTextbox";
            this.outputFilenameTextbox.Size = new System.Drawing.Size(511, 22);
            this.outputFilenameTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 999;
            this.label1.Text = "Output File:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "\"Comma Seperated Values|*.csv|All Files|*.*\"";
            this.openFileDialog.Title = "Open File";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 323);
            this.Controls.Add(this.setOutputFilenameButton);
            this.Controls.Add(this.outputFilenameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setInputFilenameButton);
            this.Controls.Add(this.inputFilenameTextbox);
            this.Controls.Add(this.inputFileNameLabel);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.outputTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(718, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(718, 370);
            this.Name = "Form1";
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
    }
}


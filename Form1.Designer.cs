namespace Scheduller
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addFile = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.transformButton = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.CheckBox();
            this.green = new System.Windows.Forms.CheckBox();
            this.blue = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addFile
            // 
            this.addFile.Location = new System.Drawing.Point(23, 471);
            this.addFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(102, 26);
            this.addFile.TabIndex = 0;
            this.addFile.Text = "Add File";
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(23, 24);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(341, 429);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(400, 24);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(336, 429);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // transformButton
            // 
            this.transformButton.Location = new System.Drawing.Point(138, 471);
            this.transformButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(102, 26);
            this.transformButton.TabIndex = 3;
            this.transformButton.Text = "Transform";
            this.transformButton.UseVisualStyleBackColor = true;
            this.transformButton.Click += new System.EventHandler(this.transformButton_Click);
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(471, 477);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(46, 17);
            this.red.TabIndex = 4;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = true;
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Location = new System.Drawing.Point(523, 477);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(55, 17);
            this.green.TabIndex = 5;
            this.green.Text = "Green";
            this.green.UseVisualStyleBackColor = true;
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(584, 477);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(47, 17);
            this.blue.TabIndex = 6;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 522);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.transformButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.addFile);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Scheduller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addFile;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button transformButton;
        private System.Windows.Forms.CheckBox red;
        private System.Windows.Forms.CheckBox green;
        private System.Windows.Forms.CheckBox blue;
    }
}


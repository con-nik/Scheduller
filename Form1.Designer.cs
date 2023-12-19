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
            this.movMergingCheck = new System.Windows.Forms.CheckBox();
            this.immediateMergingCheck = new System.Windows.Forms.CheckBox();
            this.movReabsorptionCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addFile
            // 
            this.addFile.Location = new System.Drawing.Point(31, 580);
            this.addFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(136, 32);
            this.addFile.TabIndex = 0;
            this.addFile.Text = "Add File";
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(31, 30);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(453, 527);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(533, 30);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(447, 527);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // transformButton
            // 
            this.transformButton.Location = new System.Drawing.Point(184, 580);
            this.transformButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(136, 32);
            this.transformButton.TabIndex = 3;
            this.transformButton.Text = "Transform";
            this.transformButton.UseVisualStyleBackColor = true;
            this.transformButton.Click += new System.EventHandler(this.transformButton_Click);
            // 
            // movMergingCheck
            // 
            this.movMergingCheck.AutoSize = true;
            this.movMergingCheck.Location = new System.Drawing.Point(570, 587);
            this.movMergingCheck.Margin = new System.Windows.Forms.Padding(4);
            this.movMergingCheck.Name = "movMergingCheck";
            this.movMergingCheck.Size = new System.Drawing.Size(107, 20);
            this.movMergingCheck.TabIndex = 4;
            this.movMergingCheck.Text = "Mov Merging";
            this.movMergingCheck.UseVisualStyleBackColor = true;
            // 
            // immediateMergingCheck
            // 
            this.immediateMergingCheck.AutoSize = true;
            this.immediateMergingCheck.Location = new System.Drawing.Point(685, 587);
            this.immediateMergingCheck.Margin = new System.Windows.Forms.Padding(4);
            this.immediateMergingCheck.Name = "immediateMergingCheck";
            this.immediateMergingCheck.Size = new System.Drawing.Size(144, 20);
            this.immediateMergingCheck.TabIndex = 5;
            this.immediateMergingCheck.Text = "Immediate Merging";
            this.immediateMergingCheck.UseVisualStyleBackColor = true;
            // 
            // movReabsorptionCheck
            // 
            this.movReabsorptionCheck.AutoSize = true;
            this.movReabsorptionCheck.Location = new System.Drawing.Point(837, 587);
            this.movReabsorptionCheck.Margin = new System.Windows.Forms.Padding(4);
            this.movReabsorptionCheck.Name = "movReabsorptionCheck";
            this.movReabsorptionCheck.Size = new System.Drawing.Size(140, 20);
            this.movReabsorptionCheck.TabIndex = 6;
            this.movReabsorptionCheck.Text = "Mov Reabsorption";
            this.movReabsorptionCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 642);
            this.Controls.Add(this.movReabsorptionCheck);
            this.Controls.Add(this.immediateMergingCheck);
            this.Controls.Add(this.movMergingCheck);
            this.Controls.Add(this.transformButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.addFile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.CheckBox movMergingCheck;
        private System.Windows.Forms.CheckBox immediateMergingCheck;
        private System.Windows.Forms.CheckBox movReabsorptionCheck;
    }
}


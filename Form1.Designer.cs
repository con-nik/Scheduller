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
            this.label1 = new System.Windows.Forms.Label();
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
            // movMergingCheck
            // 
            this.movMergingCheck.AutoSize = true;
            this.movMergingCheck.Location = new System.Drawing.Point(428, 477);
            this.movMergingCheck.Name = "movMergingCheck";
            this.movMergingCheck.Size = new System.Drawing.Size(88, 17);
            this.movMergingCheck.TabIndex = 4;
            this.movMergingCheck.Text = "Mov Merging";
            this.movMergingCheck.UseVisualStyleBackColor = true;
            // 
            // immediateMergingCheck
            // 
            this.immediateMergingCheck.AutoSize = true;
            this.immediateMergingCheck.Location = new System.Drawing.Point(514, 477);
            this.immediateMergingCheck.Name = "immediateMergingCheck";
            this.immediateMergingCheck.Size = new System.Drawing.Size(115, 17);
            this.immediateMergingCheck.TabIndex = 5;
            this.immediateMergingCheck.Text = "Immediate Merging";
            this.immediateMergingCheck.UseVisualStyleBackColor = true;
            // 
            // movReabsorptionCheck
            // 
            this.movReabsorptionCheck.AutoSize = true;
            this.movReabsorptionCheck.Location = new System.Drawing.Point(628, 477);
            this.movReabsorptionCheck.Name = "movReabsorptionCheck";
            this.movReabsorptionCheck.Size = new System.Drawing.Size(113, 17);
            this.movReabsorptionCheck.TabIndex = 6;
            this.movReabsorptionCheck.Text = "Mov Reabsorption";
            this.movReabsorptionCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Legend: ~: MovMerging; ~~: ImmediatMerging; ~~~: MovReabsorption";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movReabsorptionCheck);
            this.Controls.Add(this.immediateMergingCheck);
            this.Controls.Add(this.movMergingCheck);
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
        private System.Windows.Forms.CheckBox movMergingCheck;
        private System.Windows.Forms.CheckBox immediateMergingCheck;
        private System.Windows.Forms.CheckBox movReabsorptionCheck;
        private System.Windows.Forms.Label label1;
    }
}


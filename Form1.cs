using Scheduller.Logic;
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

namespace Scheduller
{
    public partial class Form1 : Form
    {
        private string[] inputCode;
        public Form1()
        {
            InitializeComponent();
            inputCode = new string[10000];
        }

        private void addFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.DefaultExt = "ins";
            openFileDialog1.Filter = "INS files (*.ins)|*.ins|All files (*.*)|*.*";

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    inputTextBox.Lines = lines;
                    inputCode = lines;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            ITransform movMerging = new MovMergingTransform();
            movMerging.Transform(inputCode);

            outputTextBox.Lines = inputCode;

            /*ITransform movMerging = new MovMergingTransform();
            string[] transformedCode = movMerging.Transform(inputCode);

            string newInstruction = "Noua instructiune";
           
            List<string> modifiedCodeList = new List<string>(transformedCode);
            modifiedCodeList.Add(newInstruction);

            inputCode = modifiedCodeList.ToArray();
            
            outputTextBox.Lines = inputCode;

            if (red.Checked)
            {
                SetColorForNewInstruction(newInstruction, Color.Red);
            }else if(green.Checked)
            {
                SetColorForNewInstruction(newInstruction, Color.DarkGreen);
            }else if(blue.Checked)
            {
                SetColorForNewInstruction(newInstruction, Color.DarkBlue);
            }*/
        }
        private void SetColorForNewInstruction(string instruction, Color color)
        {
            int startIndex = outputTextBox.Text.Length - instruction.Length;

            outputTextBox.SelectionStart = startIndex;
            outputTextBox.SelectionLength = instruction.Length;
            outputTextBox.SelectionColor = color;
        }
    }
}

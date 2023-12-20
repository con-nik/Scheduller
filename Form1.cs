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
            string[] codeCopy = inputCode.ToArray();

            if (codeCopy[0] == null)
            {
                return;
            }
           
            if (movMergingCheck.Checked)
            {
                ITransform movMerging = new MovMergingTransform();
                movMerging.Transform(codeCopy);
            }

            if (immediateMergingCheck.Checked)
            {
                ITransform movReabsortion = new ImmediateMergingTransform();
                movReabsortion.Transform(codeCopy);
            }

            if (movReabsorptionCheck.Checked)
            {
                ITransform movReabsortion = new MovReabsorptionTransform();
                movReabsortion.Transform(codeCopy);
            }

            outputTextBox.Lines = codeCopy;

            for (int i = 0; i < outputTextBox.Lines.Length; i++)
            {
                string line = outputTextBox.Lines[i];

                int tildeIndexSimple = line.IndexOf('~');
                int tildeIndexDouble = line.IndexOf("~~");
                int tildeIndexTriple = line.IndexOf("~~~");

                if (tildeIndexSimple != -1 && tildeIndexDouble == -1 && tildeIndexTriple == -1)
                {
                    outputTextBox.SelectionStart = outputTextBox.GetFirstCharIndexFromLine(i) + tildeIndexSimple + 1;
                    outputTextBox.SelectionLength = line.Length - tildeIndexSimple - 1;
                    outputTextBox.SelectionColor = Color.Red;
                    outputTextBox.SelectionLength = 0;
                }
                else if (tildeIndexDouble != -1 && tildeIndexTriple == -1)
                {
                    outputTextBox.SelectionStart = outputTextBox.GetFirstCharIndexFromLine(i) + tildeIndexDouble + 2;
                    outputTextBox.SelectionLength = line.Length - tildeIndexDouble - 2;
                    outputTextBox.SelectionColor = Color.Green;
                    outputTextBox.SelectionLength = 0;
                }
                else if (tildeIndexTriple != -1)
                {
                    outputTextBox.SelectionStart = outputTextBox.GetFirstCharIndexFromLine(i) + tildeIndexTriple + 3;
                    outputTextBox.SelectionLength = line.Length - tildeIndexTriple - 3;
                    outputTextBox.SelectionColor = Color.Blue;
                    outputTextBox.SelectionLength = 0;
                }

            }

        }
       
    }
}

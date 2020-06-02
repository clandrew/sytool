using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sytool
{
    public partial class Form1 : Form
    {
        enum Mode
        {
            ChooseTarget,
            Type,
            ViewResult
        }

        Mode mode;
        StringBuilder allText;
        int currentWordStartIndex;
        int wordCount;

        public Form1()
        {
            InitializeComponent();

            ResetTextField();
            UpdateControlVisibility(Mode.ChooseTarget);
        }

        void ResetTextField()
        {
            allText = new StringBuilder();
            wordCount = 0;
            currentWordStartIndex = -1;
        }

        private void UpdateControlVisibility(Mode newMode)
        {
            mode = newMode;

            targetWordCountLabel.Visible = mode == Mode.ChooseTarget;
            targetWordCountNumericUpDown.Visible = mode == Mode.ChooseTarget;
            startButton.Visible = mode == Mode.ChooseTarget;

            wordProgressBar.Visible = mode == Mode.Type;
            letterTextBox.Visible = mode == Mode.Type;
            finishButton.Visible = mode == Mode.Type;

            resultBox.Visible = mode == Mode.ViewResult;
            restartButton.Visible = mode == Mode.ViewResult;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            UpdateControlVisibility(Mode.Type);

            wordProgressBar.Minimum = 0;
            wordProgressBar.Value = 0;
            wordProgressBar.Maximum = (int)targetWordCountNumericUpDown.Value;

            finishButton.Enabled = false;

            this.Focus();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            UpdateControlVisibility(Mode.ViewResult);

            resultBox.Text = allText.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(mode == Mode.Type)
            {
                letterTextBox.Text = e.KeyChar.ToString();
                allText.Append(e.KeyChar);

                if (char.IsWhiteSpace(e.KeyChar))
                {
                    // Check if we're completing a word
                    if (currentWordStartIndex != -1)
                    {
                        wordCount++;
                        currentWordStartIndex = -1;
                    }
                }
                else // Input a letter
                {
                    // First word
                    if (currentWordStartIndex == -1)
                    {
                        currentWordStartIndex = allText.Length - 1;
                    }
                }

                if (wordCount <= wordProgressBar.Maximum)
                {
                    wordProgressBar.Value = wordCount;
                }

                if (wordCount >= wordProgressBar.Maximum)
                {
                    finishButton.Enabled = true;
                }
            }
        }

        private void resultBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                resultBox.SelectAll();
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            ResetTextField();
            UpdateControlVisibility(Mode.ChooseTarget);
        }
    }
}

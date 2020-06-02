using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ystool
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
        StringBuilder stringBuilder;
        int wordCount;

        public Form1()
        {
            InitializeComponent();

            stringBuilder = new StringBuilder();

            UpdateControlVisibility(Mode.ChooseTarget);

            finishButton.Enabled = false;

            wordCount = 0;
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
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            UpdateControlVisibility(Mode.Type);

            wordProgressBar.Minimum = 0;
            wordProgressBar.Maximum = (int)targetWordCountNumericUpDown.Value;
            this.Focus();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            UpdateControlVisibility(Mode.ViewResult);

            resultBox.Text = stringBuilder.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(mode == Mode.Type)
            {
                letterTextBox.Text = e.KeyChar.ToString();
                stringBuilder.Append(e.KeyChar);

                if (stringBuilder.Length > 1 && char.IsWhiteSpace(e.KeyChar) && !char.IsWhiteSpace(stringBuilder[stringBuilder.Length - 2]))
                {
                    wordCount++;
                }

                if (wordCount <= wordProgressBar.Maximum)
                {
                    wordProgressBar.Value = wordCount;
                }
                else
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
    }
}

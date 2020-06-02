namespace ystool
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
            this.startButton = new System.Windows.Forms.Button();
            this.targetWordCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.targetWordCountLabel = new System.Windows.Forms.Label();
            this.wordProgressBar = new System.Windows.Forms.ProgressBar();
            this.letterTextBox = new System.Windows.Forms.TextBox();
            this.finishButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.targetWordCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(145, 188);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(127, 61);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // targetWordCountNumericUpDown
            // 
            this.targetWordCountNumericUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.targetWordCountNumericUpDown.Location = new System.Drawing.Point(12, 44);
            this.targetWordCountNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.targetWordCountNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.targetWordCountNumericUpDown.Name = "targetWordCountNumericUpDown";
            this.targetWordCountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.targetWordCountNumericUpDown.TabIndex = 1;
            this.targetWordCountNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // targetWordCountLabel
            // 
            this.targetWordCountLabel.AutoSize = true;
            this.targetWordCountLabel.Location = new System.Drawing.Point(12, 18);
            this.targetWordCountLabel.Name = "targetWordCountLabel";
            this.targetWordCountLabel.Size = new System.Drawing.Size(101, 13);
            this.targetWordCountLabel.TabIndex = 2;
            this.targetWordCountLabel.Text = "Target Word Count:";
            // 
            // wordProgressBar
            // 
            this.wordProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wordProgressBar.Location = new System.Drawing.Point(12, 82);
            this.wordProgressBar.Name = "wordProgressBar";
            this.wordProgressBar.Size = new System.Drawing.Size(260, 23);
            this.wordProgressBar.TabIndex = 3;
            // 
            // letterTextBox
            // 
            this.letterTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.letterTextBox.Enabled = false;
            this.letterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterTextBox.Location = new System.Drawing.Point(0, 193);
            this.letterTextBox.Name = "letterTextBox";
            this.letterTextBox.Size = new System.Drawing.Size(284, 68);
            this.letterTextBox.TabIndex = 4;
            this.letterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // finishButton
            // 
            this.finishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.finishButton.Location = new System.Drawing.Point(197, 8);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 5;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(0, 0);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBox.Size = new System.Drawing.Size(284, 261);
            this.resultBox.TabIndex = 6;
            this.resultBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.resultBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.letterTextBox);
            this.Controls.Add(this.wordProgressBar);
            this.Controls.Add(this.targetWordCountLabel);
            this.Controls.Add(this.targetWordCountNumericUpDown);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.resultBox);
            this.Name = "Form1";
            this.Text = "ystool";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.targetWordCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown targetWordCountNumericUpDown;
        private System.Windows.Forms.Label targetWordCountLabel;
        private System.Windows.Forms.ProgressBar wordProgressBar;
        private System.Windows.Forms.TextBox letterTextBox;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.TextBox resultBox;
    }
}


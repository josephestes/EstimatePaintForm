namespace JosephEstesCh13PaintForm
{
    partial class PaintForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.lengthDescriptionLabel = new System.Windows.Forms.Label();
            this.widthDescriptionLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.wallAreaLabel = new System.Windows.Forms.Label();
            this.ceilingCostLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.wallCostLabel = new System.Windows.Forms.Label();
            this.ceilingAreaLabel = new System.Windows.Forms.Label();
            this.totalAreaLabel = new System.Windows.Forms.Label();
            this.invalidWidthLabel = new System.Windows.Forms.Label();
            this.invalidLengthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(329, 142);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 23);
            this.lengthTextBox.TabIndex = 1;
            this.lengthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lengthTextBox_KeyDown);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(329, 113);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 23);
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.widthTextBox_KeyDown);
            // 
            // lengthDescriptionLabel
            // 
            this.lengthDescriptionLabel.AutoSize = true;
            this.lengthDescriptionLabel.Location = new System.Drawing.Point(200, 145);
            this.lengthDescriptionLabel.Name = "lengthDescriptionLabel";
            this.lengthDescriptionLabel.Size = new System.Drawing.Size(123, 15);
            this.lengthDescriptionLabel.TabIndex = 2;
            this.lengthDescriptionLabel.Text = "Enter the room length";
            // 
            // widthDescriptionLabel
            // 
            this.widthDescriptionLabel.AutoSize = true;
            this.widthDescriptionLabel.Location = new System.Drawing.Point(204, 116);
            this.widthDescriptionLabel.Name = "widthDescriptionLabel";
            this.widthDescriptionLabel.Size = new System.Drawing.Size(119, 15);
            this.widthDescriptionLabel.TabIndex = 3;
            this.widthDescriptionLabel.Text = "Enter the room width";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(193, 273);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(274, 273);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(355, 273);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // wallAreaLabel
            // 
            this.wallAreaLabel.AutoSize = true;
            this.wallAreaLabel.Location = new System.Drawing.Point(193, 176);
            this.wallAreaLabel.Name = "wallAreaLabel";
            this.wallAreaLabel.Size = new System.Drawing.Size(60, 15);
            this.wallAreaLabel.TabIndex = 7;
            this.wallAreaLabel.Text = "Wall Area:";
            // 
            // ceilingCostLabel
            // 
            this.ceilingCostLabel.AutoSize = true;
            this.ceilingCostLabel.Location = new System.Drawing.Point(353, 206);
            this.ceilingCostLabel.Name = "ceilingCostLabel";
            this.ceilingCostLabel.Size = new System.Drawing.Size(74, 15);
            this.ceilingCostLabel.TabIndex = 8;
            this.ceilingCostLabel.Text = "Ceiling Cost:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(367, 236);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(62, 15);
            this.totalCostLabel.TabIndex = 9;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // wallCostLabel
            // 
            this.wallCostLabel.AutoSize = true;
            this.wallCostLabel.Location = new System.Drawing.Point(367, 176);
            this.wallCostLabel.Name = "wallCostLabel";
            this.wallCostLabel.Size = new System.Drawing.Size(60, 15);
            this.wallCostLabel.TabIndex = 10;
            this.wallCostLabel.Text = "Wall Cost:";
            // 
            // ceilingAreaLabel
            // 
            this.ceilingAreaLabel.AutoSize = true;
            this.ceilingAreaLabel.Location = new System.Drawing.Point(179, 206);
            this.ceilingAreaLabel.Name = "ceilingAreaLabel";
            this.ceilingAreaLabel.Size = new System.Drawing.Size(74, 15);
            this.ceilingAreaLabel.TabIndex = 11;
            this.ceilingAreaLabel.Text = "Ceiling Area:";
            // 
            // totalAreaLabel
            // 
            this.totalAreaLabel.AutoSize = true;
            this.totalAreaLabel.Location = new System.Drawing.Point(191, 236);
            this.totalAreaLabel.Name = "totalAreaLabel";
            this.totalAreaLabel.Size = new System.Drawing.Size(62, 15);
            this.totalAreaLabel.TabIndex = 12;
            this.totalAreaLabel.Text = "Total Area:";
            // 
            // invalidWidthLabel
            // 
            this.invalidWidthLabel.AutoSize = true;
            this.invalidWidthLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidWidthLabel.Location = new System.Drawing.Point(435, 116);
            this.invalidWidthLabel.Name = "invalidWidthLabel";
            this.invalidWidthLabel.Size = new System.Drawing.Size(135, 15);
            this.invalidWidthLabel.TabIndex = 13;
            this.invalidWidthLabel.Text = "Enter a positive number!";
            this.invalidWidthLabel.Visible = false;
            // 
            // invalidLengthLabel
            // 
            this.invalidLengthLabel.AutoSize = true;
            this.invalidLengthLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidLengthLabel.Location = new System.Drawing.Point(435, 145);
            this.invalidLengthLabel.Name = "invalidLengthLabel";
            this.invalidLengthLabel.Size = new System.Drawing.Size(135, 15);
            this.invalidLengthLabel.TabIndex = 14;
            this.invalidLengthLabel.Text = "Enter a positive number!";
            this.invalidLengthLabel.Visible = false;
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.invalidLengthLabel);
            this.Controls.Add(this.invalidWidthLabel);
            this.Controls.Add(this.totalAreaLabel);
            this.Controls.Add(this.ceilingAreaLabel);
            this.Controls.Add(this.wallCostLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.ceilingCostLabel);
            this.Controls.Add(this.wallAreaLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.widthDescriptionLabel);
            this.Controls.Add(this.lengthDescriptionLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Name = "PaintForm";
            this.Text = "Paint Estimater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label lengthDescriptionLabel;
        private System.Windows.Forms.Label widthDescriptionLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label wallAreaLabel;
        private System.Windows.Forms.Label ceilingCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label wallCostLabel;
        private System.Windows.Forms.Label ceilingAreaLabel;
        private System.Windows.Forms.Label totalAreaLabel;
        private System.Windows.Forms.Label invalidWidthLabel;
        private System.Windows.Forms.Label invalidLengthLabel;
    }
}

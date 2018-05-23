namespace KrallSamantha_Exercise3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.milesLabel = new System.Windows.Forms.Label();
            this.gasLabel = new System.Windows.Forms.Label();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.milesTB = new System.Windows.Forms.TextBox();
            this.gasTB = new System.Windows.Forms.TextBox();
            this.calculationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // milesLabel
            // 
            this.milesLabel.AutoSize = true;
            this.milesLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.milesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.milesLabel.Location = new System.Drawing.Point(23, 35);
            this.milesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.milesLabel.Name = "milesLabel";
            this.milesLabel.Size = new System.Drawing.Size(274, 20);
            this.milesLabel.TabIndex = 0;
            this.milesLabel.Text = "Enter the number of miles driven:";
            // 
            // gasLabel
            // 
            this.gasLabel.AutoSize = true;
            this.gasLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gasLabel.Location = new System.Drawing.Point(23, 105);
            this.gasLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.gasLabel.Name = "gasLabel";
            this.gasLabel.Size = new System.Drawing.Size(250, 20);
            this.gasLabel.TabIndex = 1;
            this.gasLabel.Text = "Enter the gallons of gas used:";
            // 
            // mpgLabel
            // 
            this.mpgLabel.AutoSize = true;
            this.mpgLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mpgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpgLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mpgLabel.Location = new System.Drawing.Point(23, 175);
            this.mpgLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(165, 20);
            this.mpgLabel.TabIndex = 2;
            this.mpgLabel.Text = "Your vehicles MPG:";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateButton.Location = new System.Drawing.Point(55, 235);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(242, 83);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "&Calculate MPG";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Location = new System.Drawing.Point(355, 235);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(242, 83);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // milesTB
            // 
            this.milesTB.Location = new System.Drawing.Point(395, 29);
            this.milesTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.milesTB.Name = "milesTB";
            this.milesTB.Size = new System.Drawing.Size(164, 26);
            this.milesTB.TabIndex = 5;
            // 
            // gasTB
            // 
            this.gasTB.Location = new System.Drawing.Point(395, 105);
            this.gasTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gasTB.Name = "gasTB";
            this.gasTB.Size = new System.Drawing.Size(164, 26);
            this.gasTB.TabIndex = 6;
            // 
            // calculationLabel
            // 
            this.calculationLabel.AutoSize = true;
            this.calculationLabel.Location = new System.Drawing.Point(510, 235);
            this.calculationLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.calculationLabel.Name = "calculationLabel";
            this.calculationLabel.Size = new System.Drawing.Size(0, 20);
            this.calculationLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(645, 396);
            this.Controls.Add(this.calculationLabel);
            this.Controls.Add(this.gasTB);
            this.Controls.Add(this.milesTB);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.gasLabel);
            this.Controls.Add(this.milesLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Vehicle MPG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.Label gasLabel;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox milesTB;
        private System.Windows.Forms.TextBox gasTB;
        private System.Windows.Forms.Label calculationLabel;
    }
}


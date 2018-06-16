namespace KrallSamantha_Exercise6
{
    partial class SnakeEyes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeEyes));
            this.rollButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.die1TB = new System.Windows.Forms.TextBox();
            this.die2TB = new System.Windows.Forms.TextBox();
            this.rollsTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.rollButton.Location = new System.Drawing.Point(38, 378);
            this.rollButton.Margin = new System.Windows.Forms.Padding(5);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(232, 120);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "&Roll";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitButton.Location = new System.Drawing.Point(362, 378);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(232, 120);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // die1TB
            // 
            this.die1TB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.die1TB.ForeColor = System.Drawing.SystemColors.Info;
            this.die1TB.Location = new System.Drawing.Point(113, 88);
            this.die1TB.Margin = new System.Windows.Forms.Padding(5);
            this.die1TB.Multiline = true;
            this.die1TB.Name = "die1TB";
            this.die1TB.ReadOnly = true;
            this.die1TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.die1TB.Size = new System.Drawing.Size(58, 122);
            this.die1TB.TabIndex = 2;
            // 
            // die2TB
            // 
            this.die2TB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.die2TB.ForeColor = System.Drawing.SystemColors.Info;
            this.die2TB.Location = new System.Drawing.Point(453, 88);
            this.die2TB.Margin = new System.Windows.Forms.Padding(5);
            this.die2TB.Multiline = true;
            this.die2TB.Name = "die2TB";
            this.die2TB.ReadOnly = true;
            this.die2TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.die2TB.Size = new System.Drawing.Size(58, 122);
            this.die2TB.TabIndex = 3;
            // 
            // rollsTB
            // 
            this.rollsTB.BackColor = System.Drawing.Color.RoyalBlue;
            this.rollsTB.Location = new System.Drawing.Point(288, 241);
            this.rollsTB.Name = "rollsTB";
            this.rollsTB.ReadOnly = true;
            this.rollsTB.Size = new System.Drawing.Size(51, 26);
            this.rollsTB.TabIndex = 4;
            this.rollsTB.TextChanged += new System.EventHandler(this.rollsTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(109, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Die 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(449, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Die 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rolls";
            // 
            // SnakeEyes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rollsTB);
            this.Controls.Add(this.die2TB);
            this.Controls.Add(this.die1TB);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rollButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SnakeEyes";
            this.Text = "Snake Eyes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox die1TB;
        private System.Windows.Forms.TextBox die2TB;
        private System.Windows.Forms.TextBox rollsTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


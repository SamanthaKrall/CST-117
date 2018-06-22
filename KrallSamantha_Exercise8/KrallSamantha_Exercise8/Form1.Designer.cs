namespace KrallSamantha_Exercise8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fatTB = new System.Windows.Forms.TextBox();
            this.carbTB = new System.Windows.Forms.TextBox();
            this.fatResultTB = new System.Windows.Forms.TextBox();
            this.carbResultTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the grams of fat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the grams of Carbohydrates:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 330);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calories from Fat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 434);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calories from Carbohydrates:";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(146, 225);
            this.calcButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(163, 42);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "&Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(444, 225);
            this.exitButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(163, 42);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fatTB
            // 
            this.fatTB.Location = new System.Drawing.Point(444, 31);
            this.fatTB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.fatTB.Name = "fatTB";
            this.fatTB.Size = new System.Drawing.Size(212, 31);
            this.fatTB.TabIndex = 6;
            // 
            // carbTB
            // 
            this.carbTB.Location = new System.Drawing.Point(444, 120);
            this.carbTB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.carbTB.Name = "carbTB";
            this.carbTB.Size = new System.Drawing.Size(212, 31);
            this.carbTB.TabIndex = 7;
            // 
            // fatResultTB
            // 
            this.fatResultTB.Location = new System.Drawing.Point(444, 330);
            this.fatResultTB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.fatResultTB.Name = "fatResultTB";
            this.fatResultTB.ReadOnly = true;
            this.fatResultTB.Size = new System.Drawing.Size(212, 31);
            this.fatResultTB.TabIndex = 8;
            // 
            // carbResultTB
            // 
            this.carbResultTB.Location = new System.Drawing.Point(444, 434);
            this.carbResultTB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.carbResultTB.Name = "carbResultTB";
            this.carbResultTB.ReadOnly = true;
            this.carbResultTB.Size = new System.Drawing.Size(212, 31);
            this.carbResultTB.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(775, 499);
            this.Controls.Add(this.carbResultTB);
            this.Controls.Add(this.fatResultTB);
            this.Controls.Add(this.carbTB);
            this.Controls.Add(this.fatTB);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Calories from Fat and Carbohydrates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox fatTB;
        private System.Windows.Forms.TextBox carbTB;
        private System.Windows.Forms.TextBox fatResultTB;
        private System.Windows.Forms.TextBox carbResultTB;
    }
}


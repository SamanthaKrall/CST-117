namespace KrallSamantha_Milestone2
{
    partial class SearchInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchInventory));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vanRB = new System.Windows.Forms.RadioButton();
            this.chocRB = new System.Windows.Forms.RadioButton();
            this.cherRB = new System.Windows.Forms.RadioButton();
            this.cofRB = new System.Windows.Forms.RadioButton();
            this.carRB = new System.Windows.Forms.RadioButton();
            this.pbRB = new System.Windows.Forms.RadioButton();
            this.searchFlavorButton = new System.Windows.Forms.Button();
            this.lowInventoryTB = new System.Windows.Forms.TextBox();
            this.calcLowInvButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.searchFlavorButton);
            this.groupBox1.Controls.Add(this.pbRB);
            this.groupBox1.Controls.Add(this.carRB);
            this.groupBox1.Controls.Add(this.cofRB);
            this.groupBox1.Controls.Add(this.cherRB);
            this.groupBox1.Controls.Add(this.chocRB);
            this.groupBox1.Controls.Add(this.vanRB);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Inventory by flavor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.calcLowInvButton);
            this.groupBox2.Controls.Add(this.lowInventoryTB);
            this.groupBox2.Location = new System.Drawing.Point(563, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 381);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "You\'re getting low on:";
            // 
            // vanRB
            // 
            this.vanRB.AutoSize = true;
            this.vanRB.Location = new System.Drawing.Point(21, 38);
            this.vanRB.Name = "vanRB";
            this.vanRB.Size = new System.Drawing.Size(81, 24);
            this.vanRB.TabIndex = 0;
            this.vanRB.TabStop = true;
            this.vanRB.Text = "Vanilla";
            this.vanRB.UseVisualStyleBackColor = true;
            // 
            // chocRB
            // 
            this.chocRB.AutoSize = true;
            this.chocRB.Location = new System.Drawing.Point(21, 80);
            this.chocRB.Name = "chocRB";
            this.chocRB.Size = new System.Drawing.Size(108, 24);
            this.chocRB.TabIndex = 1;
            this.chocRB.TabStop = true;
            this.chocRB.Text = "Chocolate";
            this.chocRB.UseVisualStyleBackColor = true;
            // 
            // cherRB
            // 
            this.cherRB.AutoSize = true;
            this.cherRB.Location = new System.Drawing.Point(21, 123);
            this.cherRB.Name = "cherRB";
            this.cherRB.Size = new System.Drawing.Size(79, 24);
            this.cherRB.TabIndex = 2;
            this.cherRB.TabStop = true;
            this.cherRB.Text = "Cherry";
            this.cherRB.UseVisualStyleBackColor = true;
            // 
            // cofRB
            // 
            this.cofRB.AutoSize = true;
            this.cofRB.Location = new System.Drawing.Point(21, 169);
            this.cofRB.Name = "cofRB";
            this.cofRB.Size = new System.Drawing.Size(81, 24);
            this.cofRB.TabIndex = 3;
            this.cofRB.TabStop = true;
            this.cofRB.Text = "Coffee";
            this.cofRB.UseVisualStyleBackColor = true;
            // 
            // carRB
            // 
            this.carRB.AutoSize = true;
            this.carRB.Location = new System.Drawing.Point(21, 215);
            this.carRB.Name = "carRB";
            this.carRB.Size = new System.Drawing.Size(93, 24);
            this.carRB.TabIndex = 4;
            this.carRB.TabStop = true;
            this.carRB.Text = "Caramel";
            this.carRB.UseVisualStyleBackColor = true;
            // 
            // pbRB
            // 
            this.pbRB.AutoSize = true;
            this.pbRB.Location = new System.Drawing.Point(21, 260);
            this.pbRB.Name = "pbRB";
            this.pbRB.Size = new System.Drawing.Size(139, 24);
            this.pbRB.TabIndex = 5;
            this.pbRB.TabStop = true;
            this.pbRB.Text = "Peanut Butter";
            this.pbRB.UseVisualStyleBackColor = true;
            // 
            // searchFlavorButton
            // 
            this.searchFlavorButton.Location = new System.Drawing.Point(21, 313);
            this.searchFlavorButton.Name = "searchFlavorButton";
            this.searchFlavorButton.Size = new System.Drawing.Size(139, 49);
            this.searchFlavorButton.TabIndex = 6;
            this.searchFlavorButton.Text = "&Search By Flavor";
            this.searchFlavorButton.UseVisualStyleBackColor = true;
            this.searchFlavorButton.Click += new System.EventHandler(this.searchFlavorButton_Click);
            // 
            // lowInventoryTB
            // 
            this.lowInventoryTB.Location = new System.Drawing.Point(24, 38);
            this.lowInventoryTB.Multiline = true;
            this.lowInventoryTB.Name = "lowInventoryTB";
            this.lowInventoryTB.ReadOnly = true;
            this.lowInventoryTB.Size = new System.Drawing.Size(197, 246);
            this.lowInventoryTB.TabIndex = 0;
            // 
            // calcLowInvButton
            // 
            this.calcLowInvButton.Location = new System.Drawing.Point(57, 313);
            this.calcLowInvButton.Name = "calcLowInvButton";
            this.calcLowInvButton.Size = new System.Drawing.Size(139, 49);
            this.calcLowInvButton.TabIndex = 1;
            this.calcLowInvButton.Text = "&Calculate";
            this.calcLowInvButton.UseVisualStyleBackColor = true;
            this.calcLowInvButton.Click += new System.EventHandler(this.calcLowInvButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(345, 351);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 49);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(818, 433);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form2";
            this.Text = "Search Inventory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchFlavorButton;
        private System.Windows.Forms.RadioButton pbRB;
        private System.Windows.Forms.RadioButton carRB;
        private System.Windows.Forms.RadioButton cofRB;
        private System.Windows.Forms.RadioButton cherRB;
        private System.Windows.Forms.RadioButton chocRB;
        private System.Windows.Forms.RadioButton vanRB;
        private System.Windows.Forms.Button calcLowInvButton;
        private System.Windows.Forms.TextBox lowInventoryTB;
        private System.Windows.Forms.Button exitButton;
    }
}
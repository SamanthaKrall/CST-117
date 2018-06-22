namespace KrallSamantha_PP2
{
    partial class pizzaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pizzaForm));
            this.sizeGB = new System.Windows.Forms.GroupBox();
            this.lgButton = new System.Windows.Forms.RadioButton();
            this.medButton = new System.Windows.Forms.RadioButton();
            this.smallButton = new System.Windows.Forms.RadioButton();
            this.toppingsGB = new System.Windows.Forms.GroupBox();
            this.oliveCB = new System.Windows.Forms.CheckBox();
            this.shroomCB = new System.Windows.Forms.CheckBox();
            this.gpCB = new System.Windows.Forms.CheckBox();
            this.pineappleCB = new System.Windows.Forms.CheckBox();
            this.sausageCB = new System.Windows.Forms.CheckBox();
            this.pepCB = new System.Windows.Forms.CheckBox();
            this.xsauseCB = new System.Windows.Forms.CheckBox();
            this.xchsCB = new System.Windows.Forms.CheckBox();
            this.shapeLB = new System.Windows.Forms.ListBox();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.sizeGB.SuspendLayout();
            this.toppingsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeGB
            // 
            this.sizeGB.Controls.Add(this.lgButton);
            this.sizeGB.Controls.Add(this.medButton);
            this.sizeGB.Controls.Add(this.smallButton);
            this.sizeGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeGB.Location = new System.Drawing.Point(12, 12);
            this.sizeGB.Name = "sizeGB";
            this.sizeGB.Size = new System.Drawing.Size(117, 146);
            this.sizeGB.TabIndex = 0;
            this.sizeGB.TabStop = false;
            this.sizeGB.Text = "Size:";
            // 
            // lgButton
            // 
            this.lgButton.AutoSize = true;
            this.lgButton.Location = new System.Drawing.Point(22, 110);
            this.lgButton.Name = "lgButton";
            this.lgButton.Size = new System.Drawing.Size(61, 20);
            this.lgButton.TabIndex = 2;
            this.lgButton.TabStop = true;
            this.lgButton.Text = "Large";
            this.lgButton.UseVisualStyleBackColor = true;
            // 
            // medButton
            // 
            this.medButton.AutoSize = true;
            this.medButton.Location = new System.Drawing.Point(22, 71);
            this.medButton.Name = "medButton";
            this.medButton.Size = new System.Drawing.Size(74, 20);
            this.medButton.TabIndex = 1;
            this.medButton.TabStop = true;
            this.medButton.Text = "Medium";
            this.medButton.UseVisualStyleBackColor = true;
            // 
            // smallButton
            // 
            this.smallButton.AutoSize = true;
            this.smallButton.Location = new System.Drawing.Point(22, 32);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(60, 20);
            this.smallButton.TabIndex = 0;
            this.smallButton.TabStop = true;
            this.smallButton.Text = "Small";
            this.smallButton.UseVisualStyleBackColor = true;
            this.smallButton.CheckedChanged += new System.EventHandler(this.smallButton_CheckedChanged);
            // 
            // toppingsGB
            // 
            this.toppingsGB.Controls.Add(this.oliveCB);
            this.toppingsGB.Controls.Add(this.shroomCB);
            this.toppingsGB.Controls.Add(this.gpCB);
            this.toppingsGB.Controls.Add(this.pineappleCB);
            this.toppingsGB.Controls.Add(this.sausageCB);
            this.toppingsGB.Controls.Add(this.pepCB);
            this.toppingsGB.Controls.Add(this.xsauseCB);
            this.toppingsGB.Controls.Add(this.xchsCB);
            this.toppingsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsGB.Location = new System.Drawing.Point(174, 12);
            this.toppingsGB.Name = "toppingsGB";
            this.toppingsGB.Size = new System.Drawing.Size(200, 241);
            this.toppingsGB.TabIndex = 1;
            this.toppingsGB.TabStop = false;
            this.toppingsGB.Text = "Choose your toppings:";
            // 
            // oliveCB
            // 
            this.oliveCB.AutoSize = true;
            this.oliveCB.Location = new System.Drawing.Point(7, 209);
            this.oliveCB.Name = "oliveCB";
            this.oliveCB.Size = new System.Drawing.Size(65, 20);
            this.oliveCB.TabIndex = 7;
            this.oliveCB.Text = "Olives";
            this.oliveCB.UseVisualStyleBackColor = true;
            // 
            // shroomCB
            // 
            this.shroomCB.AutoSize = true;
            this.shroomCB.Location = new System.Drawing.Point(7, 182);
            this.shroomCB.Name = "shroomCB";
            this.shroomCB.Size = new System.Drawing.Size(97, 20);
            this.shroomCB.TabIndex = 6;
            this.shroomCB.Text = "Mushrooms";
            this.shroomCB.UseVisualStyleBackColor = true;
            // 
            // gpCB
            // 
            this.gpCB.AutoSize = true;
            this.gpCB.Location = new System.Drawing.Point(7, 155);
            this.gpCB.Name = "gpCB";
            this.gpCB.Size = new System.Drawing.Size(119, 20);
            this.gpCB.TabIndex = 5;
            this.gpCB.Text = "Green Peppers";
            this.gpCB.UseVisualStyleBackColor = true;
            // 
            // pineappleCB
            // 
            this.pineappleCB.AutoSize = true;
            this.pineappleCB.Location = new System.Drawing.Point(7, 128);
            this.pineappleCB.Name = "pineappleCB";
            this.pineappleCB.Size = new System.Drawing.Size(89, 20);
            this.pineappleCB.TabIndex = 4;
            this.pineappleCB.Text = "Pineapple";
            this.pineappleCB.UseVisualStyleBackColor = true;
            // 
            // sausageCB
            // 
            this.sausageCB.AutoSize = true;
            this.sausageCB.Location = new System.Drawing.Point(7, 103);
            this.sausageCB.Name = "sausageCB";
            this.sausageCB.Size = new System.Drawing.Size(82, 20);
            this.sausageCB.TabIndex = 3;
            this.sausageCB.Text = "Sausage";
            this.sausageCB.UseVisualStyleBackColor = true;
            // 
            // pepCB
            // 
            this.pepCB.AutoSize = true;
            this.pepCB.Location = new System.Drawing.Point(7, 76);
            this.pepCB.Name = "pepCB";
            this.pepCB.Size = new System.Drawing.Size(90, 20);
            this.pepCB.TabIndex = 2;
            this.pepCB.Text = "Pepperoni";
            this.pepCB.UseVisualStyleBackColor = true;
            // 
            // xsauseCB
            // 
            this.xsauseCB.AutoSize = true;
            this.xsauseCB.Location = new System.Drawing.Point(7, 49);
            this.xsauseCB.Name = "xsauseCB";
            this.xsauseCB.Size = new System.Drawing.Size(99, 20);
            this.xsauseCB.TabIndex = 1;
            this.xsauseCB.Text = "Extra Sauce";
            this.xsauseCB.UseVisualStyleBackColor = true;
            // 
            // xchsCB
            // 
            this.xchsCB.AutoSize = true;
            this.xchsCB.Location = new System.Drawing.Point(7, 22);
            this.xchsCB.Name = "xchsCB";
            this.xchsCB.Size = new System.Drawing.Size(107, 20);
            this.xchsCB.TabIndex = 0;
            this.xchsCB.Text = "Extra Cheese";
            this.xchsCB.UseVisualStyleBackColor = true;
            // 
            // shapeLB
            // 
            this.shapeLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shapeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeLB.FormattingEnabled = true;
            this.shapeLB.ItemHeight = 16;
            this.shapeLB.Items.AddRange(new object[] {
            "Round",
            "Square"});
            this.shapeLB.Location = new System.Drawing.Point(12, 201);
            this.shapeLB.Name = "shapeLB";
            this.shapeLB.Size = new System.Drawing.Size(120, 52);
            this.shapeLB.TabIndex = 2;
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeLabel.Location = new System.Drawing.Point(12, 176);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(128, 16);
            this.shapeLabel.TabIndex = 3;
            this.shapeLabel.Text = "Choose your shape:";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Yellow;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(12, 277);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 40);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.Yellow;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Location = new System.Drawing.Point(139, 277);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 40);
            this.orderButton.TabIndex = 5;
            this.orderButton.Text = "&Order";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Yellow;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(265, 277);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(395, 368);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.shapeLabel);
            this.Controls.Add(this.shapeLB);
            this.Controls.Add(this.toppingsGB);
            this.Controls.Add(this.sizeGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pizzaForm";
            this.Text = "Pizza Pizza";
            this.sizeGB.ResumeLayout(false);
            this.sizeGB.PerformLayout();
            this.toppingsGB.ResumeLayout(false);
            this.toppingsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox sizeGB;
        private System.Windows.Forms.RadioButton lgButton;
        private System.Windows.Forms.RadioButton medButton;
        private System.Windows.Forms.RadioButton smallButton;
        private System.Windows.Forms.GroupBox toppingsGB;
        private System.Windows.Forms.CheckBox oliveCB;
        private System.Windows.Forms.CheckBox shroomCB;
        private System.Windows.Forms.CheckBox gpCB;
        private System.Windows.Forms.CheckBox pineappleCB;
        private System.Windows.Forms.CheckBox sausageCB;
        private System.Windows.Forms.CheckBox pepCB;
        private System.Windows.Forms.CheckBox xsauseCB;
        private System.Windows.Forms.CheckBox xchsCB;
        private System.Windows.Forms.ListBox shapeLB;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button exitButton;
    }
}


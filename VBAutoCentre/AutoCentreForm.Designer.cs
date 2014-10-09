namespace VBAutoCentre
{
    partial class AutoCentreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoCentreForm));
            this.accessoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.exteriorFinishGroupBox = new System.Windows.Forms.GroupBox();
            this.stereoCheckBox = new System.Windows.Forms.CheckBox();
            this.leatherCheckBox = new System.Windows.Forms.CheckBox();
            this.computerNavCheckBox = new System.Windows.Forms.CheckBox();
            this.standardFinishRadioButton = new System.Windows.Forms.RadioButton();
            this.pearlFinishRadioButton = new System.Windows.Forms.RadioButton();
            this.customDetailRadioButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.carSalesPriceLabel = new System.Windows.Forms.Label();
            this.accessoriesFinishLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tradeAllowanceLabel = new System.Windows.Forms.Label();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.accessoriesGroupBox.SuspendLayout();
            this.exteriorFinishGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // accessoriesGroupBox
            // 
            this.accessoriesGroupBox.Controls.Add(this.computerNavCheckBox);
            this.accessoriesGroupBox.Controls.Add(this.leatherCheckBox);
            this.accessoriesGroupBox.Controls.Add(this.stereoCheckBox);
            this.accessoriesGroupBox.Location = new System.Drawing.Point(22, 45);
            this.accessoriesGroupBox.Name = "accessoriesGroupBox";
            this.accessoriesGroupBox.Size = new System.Drawing.Size(200, 142);
            this.accessoriesGroupBox.TabIndex = 0;
            this.accessoriesGroupBox.TabStop = false;
            this.accessoriesGroupBox.Text = "Accessories";
            // 
            // exteriorFinishGroupBox
            // 
            this.exteriorFinishGroupBox.Controls.Add(this.customDetailRadioButton);
            this.exteriorFinishGroupBox.Controls.Add(this.pearlFinishRadioButton);
            this.exteriorFinishGroupBox.Controls.Add(this.standardFinishRadioButton);
            this.exteriorFinishGroupBox.Location = new System.Drawing.Point(22, 202);
            this.exteriorFinishGroupBox.Name = "exteriorFinishGroupBox";
            this.exteriorFinishGroupBox.Size = new System.Drawing.Size(200, 135);
            this.exteriorFinishGroupBox.TabIndex = 1;
            this.exteriorFinishGroupBox.TabStop = false;
            this.exteriorFinishGroupBox.Text = "Exterior Finish";
            // 
            // stereoCheckBox
            // 
            this.stereoCheckBox.AutoSize = true;
            this.stereoCheckBox.Location = new System.Drawing.Point(7, 20);
            this.stereoCheckBox.Name = "stereoCheckBox";
            this.stereoCheckBox.Size = new System.Drawing.Size(94, 17);
            this.stereoCheckBox.TabIndex = 0;
            this.stereoCheckBox.Text = "&Stereo System";
            this.stereoCheckBox.UseVisualStyleBackColor = true;
            // 
            // leatherCheckBox
            // 
            this.leatherCheckBox.AutoSize = true;
            this.leatherCheckBox.Location = new System.Drawing.Point(7, 62);
            this.leatherCheckBox.Name = "leatherCheckBox";
            this.leatherCheckBox.Size = new System.Drawing.Size(97, 17);
            this.leatherCheckBox.TabIndex = 1;
            this.leatherCheckBox.Text = "Leather &Interior";
            this.leatherCheckBox.UseVisualStyleBackColor = true;
            this.leatherCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // computerNavCheckBox
            // 
            this.computerNavCheckBox.AutoSize = true;
            this.computerNavCheckBox.Location = new System.Drawing.Point(7, 104);
            this.computerNavCheckBox.Name = "computerNavCheckBox";
            this.computerNavCheckBox.Size = new System.Drawing.Size(125, 17);
            this.computerNavCheckBox.TabIndex = 2;
            this.computerNavCheckBox.Text = "Computer &Navigation";
            this.computerNavCheckBox.UseVisualStyleBackColor = true;
            // 
            // standardFinishRadioButton
            // 
            this.standardFinishRadioButton.AutoSize = true;
            this.standardFinishRadioButton.Location = new System.Drawing.Point(7, 20);
            this.standardFinishRadioButton.Name = "standardFinishRadioButton";
            this.standardFinishRadioButton.Size = new System.Drawing.Size(68, 17);
            this.standardFinishRadioButton.TabIndex = 0;
            this.standardFinishRadioButton.TabStop = true;
            this.standardFinishRadioButton.Text = "S&tandard";
            this.standardFinishRadioButton.UseVisualStyleBackColor = true;
            // 
            // pearlFinishRadioButton
            // 
            this.pearlFinishRadioButton.AutoSize = true;
            this.pearlFinishRadioButton.Location = new System.Drawing.Point(7, 57);
            this.pearlFinishRadioButton.Name = "pearlFinishRadioButton";
            this.pearlFinishRadioButton.Size = new System.Drawing.Size(68, 17);
            this.pearlFinishRadioButton.TabIndex = 1;
            this.pearlFinishRadioButton.TabStop = true;
            this.pearlFinishRadioButton.Text = "&Pearlized";
            this.pearlFinishRadioButton.UseVisualStyleBackColor = true;
            // 
            // customDetailRadioButton
            // 
            this.customDetailRadioButton.AutoSize = true;
            this.customDetailRadioButton.Location = new System.Drawing.Point(7, 94);
            this.customDetailRadioButton.Name = "customDetailRadioButton";
            this.customDetailRadioButton.Size = new System.Drawing.Size(123, 17);
            this.customDetailRadioButton.TabIndex = 2;
            this.customDetailRadioButton.TabStop = true;
            this.customDetailRadioButton.Text = "Customized &Detailing";
            this.customDetailRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(206, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(119, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "VB Auto Centre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(379, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(379, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(379, 182);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(379, 222);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(379, 262);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(379, 302);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 9;
            // 
            // carSalesPriceLabel
            // 
            this.carSalesPriceLabel.AutoSize = true;
            this.carSalesPriceLabel.Location = new System.Drawing.Point(291, 66);
            this.carSalesPriceLabel.Name = "carSalesPriceLabel";
            this.carSalesPriceLabel.Size = new System.Drawing.Size(82, 13);
            this.carSalesPriceLabel.TabIndex = 10;
            this.carSalesPriceLabel.Text = "C&ar Sales Price:";
            this.carSalesPriceLabel.Click += new System.EventHandler(this.carSalesPriceLabel_Click);
            // 
            // accessoriesFinishLabel
            // 
            this.accessoriesFinishLabel.AutoSize = true;
            this.accessoriesFinishLabel.Location = new System.Drawing.Point(267, 105);
            this.accessoriesFinishLabel.Name = "accessoriesFinishLabel";
            this.accessoriesFinishLabel.Size = new System.Drawing.Size(106, 13);
            this.accessoriesFinishLabel.TabIndex = 11;
            this.accessoriesFinishLabel.Text = "Accessories && Finish:";
            this.accessoriesFinishLabel.Click += new System.EventHandler(this.accessoriesFinishLabel_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(324, 145);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(49, 13);
            this.subTotalLabel.TabIndex = 12;
            this.subTotalLabel.Text = "Subtotal:";
            this.subTotalLabel.Click += new System.EventHandler(this.subTotalLabel_Click);
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(287, 185);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(86, 13);
            this.salesTaxLabel.TabIndex = 13;
            this.salesTaxLabel.Text = "Sales Tax (15%):";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(339, 225);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 14;
            this.totalLabel.Text = "Total:";
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // tradeAllowanceLabel
            // 
            this.tradeAllowanceLabel.AutoSize = true;
            this.tradeAllowanceLabel.Location = new System.Drawing.Point(271, 265);
            this.tradeAllowanceLabel.Name = "tradeAllowanceLabel";
            this.tradeAllowanceLabel.Size = new System.Drawing.Size(102, 13);
            this.tradeAllowanceLabel.TabIndex = 15;
            this.tradeAllowanceLabel.Text = "T&rade-In Allowance:";
            this.tradeAllowanceLabel.Click += new System.EventHandler(this.tradeAllowanceLabel_Click);
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Location = new System.Drawing.Point(304, 305);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(69, 13);
            this.amountDueLabel.TabIndex = 16;
            this.amountDueLabel.Text = "Amount Due:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(403, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AutoCentreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 469);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.amountDueLabel);
            this.Controls.Add(this.tradeAllowanceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.accessoriesFinishLabel);
            this.Controls.Add(this.carSalesPriceLabel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.exteriorFinishGroupBox);
            this.Controls.Add(this.accessoriesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoCentreForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VB Auto Centre";
            this.Load += new System.EventHandler(this.AutoCentreForm_Load);
            this.accessoriesGroupBox.ResumeLayout(false);
            this.accessoriesGroupBox.PerformLayout();
            this.exteriorFinishGroupBox.ResumeLayout(false);
            this.exteriorFinishGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox accessoriesGroupBox;
        private System.Windows.Forms.CheckBox leatherCheckBox;
        private System.Windows.Forms.CheckBox stereoCheckBox;
        private System.Windows.Forms.GroupBox exteriorFinishGroupBox;
        private System.Windows.Forms.CheckBox computerNavCheckBox;
        private System.Windows.Forms.RadioButton customDetailRadioButton;
        private System.Windows.Forms.RadioButton pearlFinishRadioButton;
        private System.Windows.Forms.RadioButton standardFinishRadioButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label carSalesPriceLabel;
        private System.Windows.Forms.Label accessoriesFinishLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tradeAllowanceLabel;
        private System.Windows.Forms.Label amountDueLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


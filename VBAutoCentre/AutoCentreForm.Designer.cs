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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoCentreForm));
            this.accessoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.computerNavCheckBox = new System.Windows.Forms.CheckBox();
            this.leatherCheckBox = new System.Windows.Forms.CheckBox();
            this.stereoCheckBox = new System.Windows.Forms.CheckBox();
            this.exteriorFinishGroupBox = new System.Windows.Forms.GroupBox();
            this.customDetailRadioButton = new System.Windows.Forms.RadioButton();
            this.pearlFinishRadioButton = new System.Windows.Forms.RadioButton();
            this.standardFinishRadioButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.carSalesTextBox = new System.Windows.Forms.TextBox();
            this.accessoriesTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.tradeTextBox = new System.Windows.Forms.TextBox();
            this.amountDueTextBox = new System.Windows.Forms.TextBox();
            this.carSalesPriceLabel = new System.Windows.Forms.Label();
            this.accessoriesFinishLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tradeAllowanceLabel = new System.Windows.Forms.Label();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.accessoriesGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.accessoriesGroupBox.Name = "accessoriesGroupBox";
            this.accessoriesGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.accessoriesGroupBox.Size = new System.Drawing.Size(200, 142);
            this.accessoriesGroupBox.TabIndex = 4;
            this.accessoriesGroupBox.TabStop = false;
            this.accessoriesGroupBox.Text = "Accessories";
            // 
            // computerNavCheckBox
            // 
            this.computerNavCheckBox.AutoSize = true;
            this.computerNavCheckBox.Location = new System.Drawing.Point(7, 104);
            this.computerNavCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.computerNavCheckBox.Name = "computerNavCheckBox";
            this.computerNavCheckBox.Size = new System.Drawing.Size(125, 17);
            this.computerNavCheckBox.TabIndex = 2;
            this.computerNavCheckBox.Text = "Computer &Navigation";
            this.toolTip1.SetToolTip(this.computerNavCheckBox, "Do you often get lost?  Check this box to add navigation to your purchase!");
            this.computerNavCheckBox.UseVisualStyleBackColor = true;
            // 
            // leatherCheckBox
            // 
            this.leatherCheckBox.AutoSize = true;
            this.leatherCheckBox.Location = new System.Drawing.Point(7, 62);
            this.leatherCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.leatherCheckBox.Name = "leatherCheckBox";
            this.leatherCheckBox.Size = new System.Drawing.Size(97, 17);
            this.leatherCheckBox.TabIndex = 1;
            this.leatherCheckBox.Text = "Leather &Interior";
            this.toolTip1.SetToolTip(this.leatherCheckBox, "If you like the feel of leather on your seats, check this box!");
            this.leatherCheckBox.UseVisualStyleBackColor = true;
            // 
            // stereoCheckBox
            // 
            this.stereoCheckBox.AutoSize = true;
            this.stereoCheckBox.Location = new System.Drawing.Point(7, 20);
            this.stereoCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.stereoCheckBox.Name = "stereoCheckBox";
            this.stereoCheckBox.Size = new System.Drawing.Size(94, 17);
            this.stereoCheckBox.TabIndex = 0;
            this.stereoCheckBox.Text = "&Stereo System";
            this.toolTip1.SetToolTip(this.stereoCheckBox, "Love music?  Check this box to order our top of the line stereo system!");
            this.stereoCheckBox.UseVisualStyleBackColor = true;
            // 
            // exteriorFinishGroupBox
            // 
            this.exteriorFinishGroupBox.Controls.Add(this.customDetailRadioButton);
            this.exteriorFinishGroupBox.Controls.Add(this.pearlFinishRadioButton);
            this.exteriorFinishGroupBox.Controls.Add(this.standardFinishRadioButton);
            this.exteriorFinishGroupBox.Location = new System.Drawing.Point(22, 202);
            this.exteriorFinishGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exteriorFinishGroupBox.Name = "exteriorFinishGroupBox";
            this.exteriorFinishGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exteriorFinishGroupBox.Size = new System.Drawing.Size(200, 134);
            this.exteriorFinishGroupBox.TabIndex = 5;
            this.exteriorFinishGroupBox.TabStop = false;
            this.exteriorFinishGroupBox.Text = "Exterior Finish";
            // 
            // customDetailRadioButton
            // 
            this.customDetailRadioButton.AutoSize = true;
            this.customDetailRadioButton.Location = new System.Drawing.Point(7, 94);
            this.customDetailRadioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.customDetailRadioButton.Name = "customDetailRadioButton";
            this.customDetailRadioButton.Size = new System.Drawing.Size(123, 17);
            this.customDetailRadioButton.TabIndex = 2;
            this.customDetailRadioButton.TabStop = true;
            this.customDetailRadioButton.Text = "Customized &Detailing";
            this.toolTip1.SetToolTip(this.customDetailRadioButton, "   Want to stand out from the crowd?  Check here to order Custom Detailing!");
            this.customDetailRadioButton.UseVisualStyleBackColor = true;
            this.customDetailRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // pearlFinishRadioButton
            // 
            this.pearlFinishRadioButton.AutoSize = true;
            this.pearlFinishRadioButton.Location = new System.Drawing.Point(7, 56);
            this.pearlFinishRadioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pearlFinishRadioButton.Name = "pearlFinishRadioButton";
            this.pearlFinishRadioButton.Size = new System.Drawing.Size(68, 17);
            this.pearlFinishRadioButton.TabIndex = 1;
            this.pearlFinishRadioButton.TabStop = true;
            this.pearlFinishRadioButton.Text = "&Pearlized";
            this.toolTip1.SetToolTip(this.pearlFinishRadioButton, "Chesk this box if you would like your car to have a pearlized finish");
            this.pearlFinishRadioButton.UseVisualStyleBackColor = true;
            this.pearlFinishRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // standardFinishRadioButton
            // 
            this.standardFinishRadioButton.AutoSize = true;
            this.standardFinishRadioButton.Location = new System.Drawing.Point(7, 20);
            this.standardFinishRadioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.standardFinishRadioButton.Name = "standardFinishRadioButton";
            this.standardFinishRadioButton.Size = new System.Drawing.Size(68, 17);
            this.standardFinishRadioButton.TabIndex = 0;
            this.standardFinishRadioButton.TabStop = true;
            this.standardFinishRadioButton.Text = "S&tandard";
            this.toolTip1.SetToolTip(this.standardFinishRadioButton, "Standard finish is a great choice; and it\'s free!");
            this.standardFinishRadioButton.UseVisualStyleBackColor = true;
            this.standardFinishRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(206, 13);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(119, 17);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "VB Auto Centre";
            // 
            // carSalesTextBox
            // 
            this.carSalesTextBox.Location = new System.Drawing.Point(379, 62);
            this.carSalesTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.carSalesTextBox.Name = "carSalesTextBox";
            this.carSalesTextBox.Size = new System.Drawing.Size(100, 20);
            this.carSalesTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.carSalesTextBox, " Please enter the base purchase price of the car here");
            // 
            // accessoriesTextBox
            // 
            this.accessoriesTextBox.Location = new System.Drawing.Point(379, 103);
            this.accessoriesTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.accessoriesTextBox.Name = "accessoriesTextBox";
            this.accessoriesTextBox.ReadOnly = true;
            this.accessoriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.accessoriesTextBox.TabIndex = 11;
            this.accessoriesTextBox.TabStop = false;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(379, 142);
            this.subTotalTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.subTotalTextBox.TabIndex = 13;
            this.subTotalTextBox.TabStop = false;
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Location = new System.Drawing.Point(379, 182);
            this.salesTaxTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.ReadOnly = true;
            this.salesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.salesTaxTextBox.TabIndex = 15;
            this.salesTaxTextBox.TabStop = false;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(379, 222);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 17;
            this.totalTextBox.TabStop = false;
            // 
            // tradeTextBox
            // 
            this.tradeTextBox.Location = new System.Drawing.Point(379, 261);
            this.tradeTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tradeTextBox.Name = "tradeTextBox";
            this.tradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.tradeTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tradeTextBox, "If you have a car to trade, enter it\'s trade-in value here");
            // 
            // amountDueTextBox
            // 
            this.amountDueTextBox.Location = new System.Drawing.Point(379, 302);
            this.amountDueTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.amountDueTextBox.Name = "amountDueTextBox";
            this.amountDueTextBox.ReadOnly = true;
            this.amountDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountDueTextBox.TabIndex = 19;
            this.amountDueTextBox.TabStop = false;
            // 
            // carSalesPriceLabel
            // 
            this.carSalesPriceLabel.AutoSize = true;
            this.carSalesPriceLabel.Location = new System.Drawing.Point(290, 66);
            this.carSalesPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carSalesPriceLabel.Name = "carSalesPriceLabel";
            this.carSalesPriceLabel.Size = new System.Drawing.Size(82, 13);
            this.carSalesPriceLabel.TabIndex = 0;
            this.carSalesPriceLabel.Text = "C&ar Sales Price:";
            // 
            // accessoriesFinishLabel
            // 
            this.accessoriesFinishLabel.AutoSize = true;
            this.accessoriesFinishLabel.Location = new System.Drawing.Point(266, 105);
            this.accessoriesFinishLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accessoriesFinishLabel.Name = "accessoriesFinishLabel";
            this.accessoriesFinishLabel.Size = new System.Drawing.Size(106, 13);
            this.accessoriesFinishLabel.TabIndex = 10;
            this.accessoriesFinishLabel.Text = "Accessories && Finish:";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(324, 144);
            this.subTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(49, 13);
            this.subTotalLabel.TabIndex = 12;
            this.subTotalLabel.Text = "Subtotal:";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(287, 185);
            this.salesTaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(86, 13);
            this.salesTaxLabel.TabIndex = 14;
            this.salesTaxLabel.Text = "Sales Tax (15%):";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(338, 225);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 16;
            this.totalLabel.Text = "Total:";
            // 
            // tradeAllowanceLabel
            // 
            this.tradeAllowanceLabel.AutoSize = true;
            this.tradeAllowanceLabel.Location = new System.Drawing.Point(271, 264);
            this.tradeAllowanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tradeAllowanceLabel.Name = "tradeAllowanceLabel";
            this.tradeAllowanceLabel.Size = new System.Drawing.Size(102, 13);
            this.tradeAllowanceLabel.TabIndex = 2;
            this.tradeAllowanceLabel.Text = "T&rade-In Allowance:";
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Location = new System.Drawing.Point(304, 305);
            this.amountDueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(69, 13);
            this.amountDueLabel.TabIndex = 18;
            this.amountDueLabel.Text = "Amount Due:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(209, 360);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(74, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(306, 360);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(74, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(403, 360);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(74, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Architect 1", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(379, 413);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(99, 21);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "Kelly McAlpine";
            // 
            // AutoCentreForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(493, 439);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.amountDueLabel);
            this.Controls.Add(this.tradeAllowanceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.accessoriesFinishLabel);
            this.Controls.Add(this.carSalesPriceLabel);
            this.Controls.Add(this.amountDueTextBox);
            this.Controls.Add(this.tradeTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.salesTaxTextBox);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(this.accessoriesTextBox);
            this.Controls.Add(this.carSalesTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.exteriorFinishGroupBox);
            this.Controls.Add(this.accessoriesGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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


        private System.Windows.Forms.GroupBox accessoriesGroupBox;
        private System.Windows.Forms.CheckBox leatherCheckBox;
        private System.Windows.Forms.CheckBox stereoCheckBox;
        private System.Windows.Forms.GroupBox exteriorFinishGroupBox;
        private System.Windows.Forms.CheckBox computerNavCheckBox;
        private System.Windows.Forms.RadioButton customDetailRadioButton;
        private System.Windows.Forms.RadioButton pearlFinishRadioButton;
        private System.Windows.Forms.RadioButton standardFinishRadioButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox carSalesTextBox;
        private System.Windows.Forms.TextBox accessoriesTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox tradeTextBox;
        private System.Windows.Forms.TextBox amountDueTextBox;
        private System.Windows.Forms.Label carSalesPriceLabel;
        private System.Windows.Forms.Label accessoriesFinishLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tradeAllowanceLabel;
        private System.Windows.Forms.Label amountDueLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
        #endregion
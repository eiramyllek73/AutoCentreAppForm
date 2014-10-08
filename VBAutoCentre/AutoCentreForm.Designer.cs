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
            this.accessoriesGroupBox.SuspendLayout();
            this.exteriorFinishGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // accessoriesGroupBox
            // 
            this.accessoriesGroupBox.Controls.Add(this.computerNavCheckBox);
            this.accessoriesGroupBox.Controls.Add(this.leatherCheckBox);
            this.accessoriesGroupBox.Controls.Add(this.stereoCheckBox);
            this.accessoriesGroupBox.Location = new System.Drawing.Point(22, 25);
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
            this.exteriorFinishGroupBox.Location = new System.Drawing.Point(22, 188);
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
            this.nameLabel.Location = new System.Drawing.Point(229, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "label1";
            // 
            // AutoCentreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 469);
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
    }
}


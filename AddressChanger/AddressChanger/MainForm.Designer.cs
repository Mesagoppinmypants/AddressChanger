namespace AddressChanger
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.newAddressLabel = new System.Windows.Forms.Label();
            this.newAddressTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.multipleInstancesCheckBox = new System.Windows.Forms.CheckBox();
            this.gameDirectoryButton = new System.Windows.Forms.Button();
            this.currentAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(74, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(238, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "SWG NGE Address Changer\nCreated By Iosnowore";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(12, 159);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // newAddressLabel
            // 
            this.newAddressLabel.AutoSize = true;
            this.newAddressLabel.Location = new System.Drawing.Point(9, 117);
            this.newAddressLabel.Name = "newAddressLabel";
            this.newAddressLabel.Size = new System.Drawing.Size(70, 13);
            this.newAddressLabel.TabIndex = 4;
            this.newAddressLabel.Text = "New Address";
            // 
            // newAddressTextBox
            // 
            this.newAddressTextBox.Location = new System.Drawing.Point(12, 133);
            this.newAddressTextBox.Name = "newAddressTextBox";
            this.newAddressTextBox.Size = new System.Drawing.Size(154, 20);
            this.newAddressTextBox.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(156, 226);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // multipleInstancesCheckBox
            // 
            this.multipleInstancesCheckBox.AutoSize = true;
            this.multipleInstancesCheckBox.Location = new System.Drawing.Point(172, 133);
            this.multipleInstancesCheckBox.Name = "multipleInstancesCheckBox";
            this.multipleInstancesCheckBox.Size = new System.Drawing.Size(111, 17);
            this.multipleInstancesCheckBox.TabIndex = 10;
            this.multipleInstancesCheckBox.Text = "Multiple Instances";
            this.multipleInstancesCheckBox.UseVisualStyleBackColor = true;
            // 
            // gameDirectoryButton
            // 
            this.gameDirectoryButton.Location = new System.Drawing.Point(172, 85);
            this.gameDirectoryButton.Name = "gameDirectoryButton";
            this.gameDirectoryButton.Size = new System.Drawing.Size(75, 35);
            this.gameDirectoryButton.TabIndex = 11;
            this.gameDirectoryButton.Text = "Game Directory";
            this.gameDirectoryButton.UseVisualStyleBackColor = true;
            this.gameDirectoryButton.Click += new System.EventHandler(this.gameDirectoryButton_Click);
            // 
            // currentAddressTextBox
            // 
            this.currentAddressTextBox.Location = new System.Drawing.Point(12, 85);
            this.currentAddressTextBox.Name = "currentAddressTextBox";
            this.currentAddressTextBox.ReadOnly = true;
            this.currentAddressTextBox.Size = new System.Drawing.Size(154, 20);
            this.currentAddressTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Current Address";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 261);
            this.Controls.Add(this.currentAddressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameDirectoryButton);
            this.Controls.Add(this.multipleInstancesCheckBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.newAddressTextBox);
            this.Controls.Add(this.newAddressLabel);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[SWG NGE] Address Changer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label newAddressLabel;
        private System.Windows.Forms.TextBox newAddressTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox multipleInstancesCheckBox;
        private System.Windows.Forms.Button gameDirectoryButton;
        private System.Windows.Forms.TextBox currentAddressTextBox;
        private System.Windows.Forms.Label label1;
    }
}


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
            this.gameDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.gameDirectoryLabel = new System.Windows.Forms.Label();
            this.newAddressLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changeDirButton = new System.Windows.Forms.Button();
            this.openDirButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
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
            this.applyButton.Location = new System.Drawing.Point(12, 192);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // gameDirectoryTextBox
            // 
            this.gameDirectoryTextBox.Location = new System.Drawing.Point(12, 81);
            this.gameDirectoryTextBox.Name = "gameDirectoryTextBox";
            this.gameDirectoryTextBox.Size = new System.Drawing.Size(362, 20);
            this.gameDirectoryTextBox.TabIndex = 2;
            // 
            // gameDirectoryLabel
            // 
            this.gameDirectoryLabel.AutoSize = true;
            this.gameDirectoryLabel.Location = new System.Drawing.Point(9, 65);
            this.gameDirectoryLabel.Name = "gameDirectoryLabel";
            this.gameDirectoryLabel.Size = new System.Drawing.Size(109, 13);
            this.gameDirectoryLabel.TabIndex = 3;
            this.gameDirectoryLabel.Text = "SWG Game Directory";
            // 
            // newAddressLabel
            // 
            this.newAddressLabel.AutoSize = true;
            this.newAddressLabel.Location = new System.Drawing.Point(12, 150);
            this.newAddressLabel.Name = "newAddressLabel";
            this.newAddressLabel.Size = new System.Drawing.Size(70, 13);
            this.newAddressLabel.TabIndex = 4;
            this.newAddressLabel.Text = "New Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 5;
            // 
            // changeDirButton
            // 
            this.changeDirButton.Location = new System.Drawing.Point(12, 107);
            this.changeDirButton.Name = "changeDirButton";
            this.changeDirButton.Size = new System.Drawing.Size(75, 23);
            this.changeDirButton.TabIndex = 6;
            this.changeDirButton.Text = "Change";
            this.changeDirButton.UseVisualStyleBackColor = true;
            // 
            // openDirButton
            // 
            this.openDirButton.Location = new System.Drawing.Point(93, 107);
            this.openDirButton.Name = "openDirButton";
            this.openDirButton.Size = new System.Drawing.Size(75, 23);
            this.openDirButton.TabIndex = 7;
            this.openDirButton.Text = "Open";
            this.openDirButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(156, 226);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 261);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openDirButton);
            this.Controls.Add(this.changeDirButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newAddressLabel);
            this.Controls.Add(this.gameDirectoryLabel);
            this.Controls.Add(this.gameDirectoryTextBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[SWG NGE] Address Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox gameDirectoryTextBox;
        private System.Windows.Forms.Label gameDirectoryLabel;
        private System.Windows.Forms.Label newAddressLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button changeDirButton;
        private System.Windows.Forms.Button openDirButton;
        private System.Windows.Forms.Button closeButton;
    }
}


namespace AddressChanger
{
    partial class Extras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extras));
            this.openDirButton = new System.Windows.Forms.Button();
            this.changeDirButton = new System.Windows.Forms.Button();
            this.gameDirectoryLabel = new System.Windows.Forms.Label();
            this.gameDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openDirButton
            // 
            this.openDirButton.Location = new System.Drawing.Point(96, 51);
            this.openDirButton.Name = "openDirButton";
            this.openDirButton.Size = new System.Drawing.Size(75, 23);
            this.openDirButton.TabIndex = 11;
            this.openDirButton.Text = "Open";
            this.openDirButton.UseVisualStyleBackColor = true;
            this.openDirButton.Click += new System.EventHandler(this.openDirButton_Click);
            // 
            // changeDirButton
            // 
            this.changeDirButton.Location = new System.Drawing.Point(15, 51);
            this.changeDirButton.Name = "changeDirButton";
            this.changeDirButton.Size = new System.Drawing.Size(75, 23);
            this.changeDirButton.TabIndex = 10;
            this.changeDirButton.Text = "Change";
            this.changeDirButton.UseVisualStyleBackColor = true;
            this.changeDirButton.Click += new System.EventHandler(this.changeDirButton_Click);
            // 
            // gameDirectoryLabel
            // 
            this.gameDirectoryLabel.AutoSize = true;
            this.gameDirectoryLabel.Location = new System.Drawing.Point(12, 9);
            this.gameDirectoryLabel.Name = "gameDirectoryLabel";
            this.gameDirectoryLabel.Size = new System.Drawing.Size(109, 13);
            this.gameDirectoryLabel.TabIndex = 9;
            this.gameDirectoryLabel.Text = "SWG Game Directory";
            // 
            // gameDirectoryTextBox
            // 
            this.gameDirectoryTextBox.Location = new System.Drawing.Point(15, 25);
            this.gameDirectoryTextBox.Name = "gameDirectoryTextBox";
            this.gameDirectoryTextBox.ReadOnly = true;
            this.gameDirectoryTextBox.Size = new System.Drawing.Size(257, 20);
            this.gameDirectoryTextBox.TabIndex = 8;
            // 
            // Extras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.openDirButton);
            this.Controls.Add(this.changeDirButton);
            this.Controls.Add(this.gameDirectoryLabel);
            this.Controls.Add(this.gameDirectoryTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Extras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extras";
            this.Load += new System.EventHandler(this.Extras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openDirButton;
        private System.Windows.Forms.Button changeDirButton;
        private System.Windows.Forms.Label gameDirectoryLabel;
        private System.Windows.Forms.TextBox gameDirectoryTextBox;
    }
}
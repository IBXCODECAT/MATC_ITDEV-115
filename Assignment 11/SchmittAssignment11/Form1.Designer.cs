namespace ContactsApp
{
    partial class WindowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactDropdown = new System.Windows.Forms.ComboBox();
            this.txtContactSearch = new System.Windows.Forms.Label();
            this.inpEmail = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // contactDropdown
            // 
            this.contactDropdown.FormattingEnabled = true;
            this.contactDropdown.Location = new System.Drawing.Point(12, 40);
            this.contactDropdown.Name = "contactDropdown";
            this.contactDropdown.Size = new System.Drawing.Size(121, 21);
            this.contactDropdown.TabIndex = 1;
            // 
            // txtContactSearch
            // 
            this.txtContactSearch.AutoSize = true;
            this.txtContactSearch.Location = new System.Drawing.Point(12, 24);
            this.txtContactSearch.Name = "txtContactSearch";
            this.txtContactSearch.Size = new System.Drawing.Size(99, 13);
            this.txtContactSearch.TabIndex = 2;
            this.txtContactSearch.Text = "Search For Contact";
            // 
            // inpEmail
            // 
            this.inpEmail.Location = new System.Drawing.Point(154, 40);
            this.inpEmail.Name = "inpEmail";
            this.inpEmail.ReadOnly = true;
            this.inpEmail.Size = new System.Drawing.Size(140, 20);
            this.inpEmail.TabIndex = 3;
            this.inpEmail.Text = "Email Address:";
            this.inpEmail.WordWrap = false;
            // 
            // picBox
            // 
            this.picBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBox.InitialImage")));
            this.picBox.Location = new System.Drawing.Point(271, 105);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(446, 271);
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // WindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.inpEmail);
            this.Controls.Add(this.txtContactSearch);
            this.Controls.Add(this.contactDropdown);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "WindowsForm";
            this.Text = "Contacts Application Thingy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ComboBox contactDropdown;
        private System.Windows.Forms.Label txtContactSearch;
        private System.Windows.Forms.TextBox inpEmail;
        private System.Windows.Forms.PictureBox picBox;
    }
}


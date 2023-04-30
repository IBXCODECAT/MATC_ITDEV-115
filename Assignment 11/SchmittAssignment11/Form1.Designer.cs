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
            this.inpFullName = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.inpAddress = new System.Windows.Forms.TextBox();
            this.inpCity = new System.Windows.Forms.TextBox();
            this.inpState = new System.Windows.Forms.TextBox();
            this.inpZip = new System.Windows.Forms.TextBox();
            this.inpPhone = new System.Windows.Forms.TextBox();
            this.inpEmail = new System.Windows.Forms.TextBox();
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
            this.menuStrip.Size = new System.Drawing.Size(1091, 24);
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
            this.contactDropdown.SelectedIndexChanged += new System.EventHandler(this.SelectedContactChanged);
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
            // inpFullName
            // 
            this.inpFullName.Location = new System.Drawing.Point(154, 40);
            this.inpFullName.Name = "inpFullName";
            this.inpFullName.ReadOnly = true;
            this.inpFullName.Size = new System.Drawing.Size(140, 20);
            this.inpFullName.TabIndex = 3;
            this.inpFullName.Text = "Full Name";
            this.inpFullName.WordWrap = false;
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBox.InitialImage")));
            this.picBox.Location = new System.Drawing.Point(591, 227);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(500, 366);
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // inpAddress
            // 
            this.inpAddress.Location = new System.Drawing.Point(154, 66);
            this.inpAddress.Name = "inpAddress";
            this.inpAddress.ReadOnly = true;
            this.inpAddress.Size = new System.Drawing.Size(140, 20);
            this.inpAddress.TabIndex = 5;
            this.inpAddress.Text = "Address";
            this.inpAddress.WordWrap = false;
            // 
            // inpCity
            // 
            this.inpCity.Location = new System.Drawing.Point(154, 92);
            this.inpCity.Name = "inpCity";
            this.inpCity.ReadOnly = true;
            this.inpCity.Size = new System.Drawing.Size(140, 20);
            this.inpCity.TabIndex = 6;
            this.inpCity.Text = "City";
            this.inpCity.WordWrap = false;
            // 
            // inpState
            // 
            this.inpState.Location = new System.Drawing.Point(154, 118);
            this.inpState.Name = "inpState";
            this.inpState.ReadOnly = true;
            this.inpState.Size = new System.Drawing.Size(140, 20);
            this.inpState.TabIndex = 7;
            this.inpState.Text = "State";
            this.inpState.WordWrap = false;
            // 
            // inpZip
            // 
            this.inpZip.Location = new System.Drawing.Point(154, 144);
            this.inpZip.Name = "inpZip";
            this.inpZip.ReadOnly = true;
            this.inpZip.Size = new System.Drawing.Size(140, 20);
            this.inpZip.TabIndex = 8;
            this.inpZip.Text = "Zip Code";
            this.inpZip.WordWrap = false;
            // 
            // inpPhone
            // 
            this.inpPhone.Location = new System.Drawing.Point(154, 170);
            this.inpPhone.Name = "inpPhone";
            this.inpPhone.ReadOnly = true;
            this.inpPhone.Size = new System.Drawing.Size(140, 20);
            this.inpPhone.TabIndex = 9;
            this.inpPhone.Text = "Phone Number";
            this.inpPhone.WordWrap = false;
            // 
            // inpEmail
            // 
            this.inpEmail.Location = new System.Drawing.Point(154, 196);
            this.inpEmail.Name = "inpEmail";
            this.inpEmail.ReadOnly = true;
            this.inpEmail.Size = new System.Drawing.Size(140, 20);
            this.inpEmail.TabIndex = 10;
            this.inpEmail.Text = "Email Address";
            this.inpEmail.WordWrap = false;
            // 
            // WindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 595);
            this.Controls.Add(this.inpEmail);
            this.Controls.Add(this.inpPhone);
            this.Controls.Add(this.inpZip);
            this.Controls.Add(this.inpState);
            this.Controls.Add(this.inpCity);
            this.Controls.Add(this.inpAddress);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.inpFullName);
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
        private System.Windows.Forms.TextBox inpFullName;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox inpAddress;
        private System.Windows.Forms.TextBox inpCity;
        private System.Windows.Forms.TextBox inpState;
        private System.Windows.Forms.TextBox inpZip;
        private System.Windows.Forms.TextBox inpPhone;
        private System.Windows.Forms.TextBox inpEmail;
    }
}


namespace Schmitt_GUI_FarmerChickenGrainGame
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Water = new System.Windows.Forms.PictureBox();
            this.NorthBank = new System.Windows.Forms.PictureBox();
            this.SouthBank = new System.Windows.Forms.PictureBox();
            this.Farmer = new System.Windows.Forms.PictureBox();
            this.Fox = new System.Windows.Forms.PictureBox();
            this.Chicken = new System.Windows.Forms.PictureBox();
            this.Grain = new System.Windows.Forms.PictureBox();
            this.WinLoss = new System.Windows.Forms.TextBox();
            this.NewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Water)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Farmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grain)).BeginInit();
            this.SuspendLayout();
            // 
            // Water
            // 
            this.Water.BackColor = System.Drawing.Color.Black;
            this.Water.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Water.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Water.Image = ((System.Drawing.Image)(resources.GetObject("Water.Image")));
            this.Water.Location = new System.Drawing.Point(0, 0);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(980, 557);
            this.Water.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Water.TabIndex = 0;
            this.Water.TabStop = false;
            this.Water.Click += new System.EventHandler(this.Water_Click);
            // 
            // NorthBank
            // 
            this.NorthBank.BackColor = System.Drawing.Color.Magenta;
            this.NorthBank.Dock = System.Windows.Forms.DockStyle.Top;
            this.NorthBank.Image = ((System.Drawing.Image)(resources.GetObject("NorthBank.Image")));
            this.NorthBank.Location = new System.Drawing.Point(0, 0);
            this.NorthBank.Name = "NorthBank";
            this.NorthBank.Size = new System.Drawing.Size(980, 200);
            this.NorthBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NorthBank.TabIndex = 2;
            this.NorthBank.TabStop = false;
            // 
            // SouthBank
            // 
            this.SouthBank.BackColor = System.Drawing.Color.Magenta;
            this.SouthBank.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SouthBank.Image = ((System.Drawing.Image)(resources.GetObject("SouthBank.Image")));
            this.SouthBank.Location = new System.Drawing.Point(0, 357);
            this.SouthBank.Name = "SouthBank";
            this.SouthBank.Size = new System.Drawing.Size(980, 200);
            this.SouthBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SouthBank.TabIndex = 3;
            this.SouthBank.TabStop = false;
            // 
            // Farmer
            // 
            this.Farmer.BackColor = System.Drawing.Color.Transparent;
            this.Farmer.Image = ((System.Drawing.Image)(resources.GetObject("Farmer.Image")));
            this.Farmer.Location = new System.Drawing.Point(32, 32);
            this.Farmer.Name = "Farmer";
            this.Farmer.Size = new System.Drawing.Size(128, 128);
            this.Farmer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Farmer.TabIndex = 4;
            this.Farmer.TabStop = false;
            // 
            // Fox
            // 
            this.Fox.BackColor = System.Drawing.Color.Transparent;
            this.Fox.Image = ((System.Drawing.Image)(resources.GetObject("Fox.Image")));
            this.Fox.Location = new System.Drawing.Point(166, 32);
            this.Fox.Name = "Fox";
            this.Fox.Size = new System.Drawing.Size(128, 128);
            this.Fox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fox.TabIndex = 5;
            this.Fox.TabStop = false;
            // 
            // Chicken
            // 
            this.Chicken.BackColor = System.Drawing.Color.Transparent;
            this.Chicken.Image = ((System.Drawing.Image)(resources.GetObject("Chicken.Image")));
            this.Chicken.Location = new System.Drawing.Point(300, 32);
            this.Chicken.Name = "Chicken";
            this.Chicken.Size = new System.Drawing.Size(128, 128);
            this.Chicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Chicken.TabIndex = 6;
            this.Chicken.TabStop = false;
            // 
            // Grain
            // 
            this.Grain.BackColor = System.Drawing.Color.Transparent;
            this.Grain.Image = ((System.Drawing.Image)(resources.GetObject("Grain.Image")));
            this.Grain.Location = new System.Drawing.Point(434, 32);
            this.Grain.Name = "Grain";
            this.Grain.Size = new System.Drawing.Size(128, 128);
            this.Grain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Grain.TabIndex = 7;
            this.Grain.TabStop = false;
            // 
            // WinLoss
            // 
            this.WinLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.WinLoss.ForeColor = System.Drawing.SystemColors.WindowText;
            this.WinLoss.Location = new System.Drawing.Point(55, 267);
            this.WinLoss.Name = "WinLoss";
            this.WinLoss.ReadOnly = true;
            this.WinLoss.Size = new System.Drawing.Size(880, 38);
            this.WinLoss.TabIndex = 8;
            this.WinLoss.Text = "No Text";
            this.WinLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WinLoss.Visible = false;
            // 
            // NewGame
            // 
            this.NewGame.Enabled = false;
            this.NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.NewGame.Location = new System.Drawing.Point(393, 311);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(187, 97);
            this.NewGame.TabIndex = 9;
            this.NewGame.Text = "NEW GAME";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.WinLoss);
            this.Controls.Add(this.Grain);
            this.Controls.Add(this.Chicken);
            this.Controls.Add(this.Fox);
            this.Controls.Add(this.Farmer);
            this.Controls.Add(this.SouthBank);
            this.Controls.Add(this.NorthBank);
            this.Controls.Add(this.Water);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Game";
            this.Text = "Chicken Farmer Grain Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Water)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Farmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Water;
        private System.Windows.Forms.PictureBox NorthBank;
        private System.Windows.Forms.PictureBox SouthBank;
        private System.Windows.Forms.PictureBox Farmer;
        private System.Windows.Forms.PictureBox Fox;
        private System.Windows.Forms.PictureBox Chicken;
        private System.Windows.Forms.PictureBox Grain;
        private System.Windows.Forms.TextBox WinLoss;
        private System.Windows.Forms.Button NewGame;
    }
}


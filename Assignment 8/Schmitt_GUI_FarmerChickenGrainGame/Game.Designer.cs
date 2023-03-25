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
            ((System.ComponentModel.ISupportInitialize)(this.Water)).BeginInit();
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
            this.Water.Size = new System.Drawing.Size(1072, 567);
            this.Water.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Water.TabIndex = 0;
            this.Water.TabStop = false;
            this.Water.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1072, 567);
            this.Controls.Add(this.Water);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Water)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Water;
    }
}


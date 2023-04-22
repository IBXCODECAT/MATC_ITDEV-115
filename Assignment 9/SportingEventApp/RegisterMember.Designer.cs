namespace SportingEventApp
{
    partial class RegisterMember
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cmboState = new System.Windows.Forms.ComboBox();
            this.rdoSkiing = new System.Windows.Forms.RadioButton();
            this.rdoBaseball = new System.Windows.Forms.RadioButton();
            this.rdoBasketball = new System.Windows.Forms.RadioButton();
            this.rdoAmericanFootball = new System.Windows.Forms.RadioButton();
            this.rdoFootball = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblFeedbackText = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(64, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(12, 48);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(96, 16);
            this.lblStreetAddress.TabIndex = 2;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(124, 45);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(214, 22);
            this.txtStreetAddress.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(79, 82);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(124, 79);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(214, 22);
            this.txtCity.TabIndex = 5;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(369, 82);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 16);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State";
            // 
            // cmboState
            // 
            this.cmboState.FormattingEnabled = true;
            this.cmboState.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "Washington DC",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.cmboState.Location = new System.Drawing.Point(413, 79);
            this.cmboState.Name = "cmboState";
            this.cmboState.Size = new System.Drawing.Size(121, 24);
            this.cmboState.TabIndex = 7;
            // 
            // rdoSkiing
            // 
            this.rdoSkiing.AutoSize = true;
            this.rdoSkiing.Location = new System.Drawing.Point(276, 121);
            this.rdoSkiing.Name = "rdoSkiing";
            this.rdoSkiing.Size = new System.Drawing.Size(65, 20);
            this.rdoSkiing.TabIndex = 8;
            this.rdoSkiing.TabStop = true;
            this.rdoSkiing.Text = "Skiing";
            this.rdoSkiing.UseVisualStyleBackColor = true;
            // 
            // rdoBaseball
            // 
            this.rdoBaseball.AutoSize = true;
            this.rdoBaseball.Location = new System.Drawing.Point(124, 121);
            this.rdoBaseball.Name = "rdoBaseball";
            this.rdoBaseball.Size = new System.Drawing.Size(82, 20);
            this.rdoBaseball.TabIndex = 9;
            this.rdoBaseball.TabStop = true;
            this.rdoBaseball.Text = "Baseball";
            this.rdoBaseball.UseVisualStyleBackColor = true;
            // 
            // rdoBasketball
            // 
            this.rdoBasketball.AutoSize = true;
            this.rdoBasketball.Location = new System.Drawing.Point(276, 147);
            this.rdoBasketball.Name = "rdoBasketball";
            this.rdoBasketball.Size = new System.Drawing.Size(92, 20);
            this.rdoBasketball.TabIndex = 10;
            this.rdoBasketball.TabStop = true;
            this.rdoBasketball.Text = "Basketball";
            this.rdoBasketball.UseVisualStyleBackColor = true;
            // 
            // rdoAmericanFootball
            // 
            this.rdoAmericanFootball.AutoSize = true;
            this.rdoAmericanFootball.Location = new System.Drawing.Point(124, 147);
            this.rdoAmericanFootball.Name = "rdoAmericanFootball";
            this.rdoAmericanFootball.Size = new System.Drawing.Size(137, 20);
            this.rdoAmericanFootball.TabIndex = 11;
            this.rdoAmericanFootball.TabStop = true;
            this.rdoAmericanFootball.Text = "American Football";
            this.rdoAmericanFootball.UseVisualStyleBackColor = true;
            // 
            // rdoFootball
            // 
            this.rdoFootball.AutoSize = true;
            this.rdoFootball.Location = new System.Drawing.Point(124, 173);
            this.rdoFootball.Name = "rdoFootball";
            this.rdoFootball.Size = new System.Drawing.Size(77, 20);
            this.rdoFootball.TabIndex = 12;
            this.rdoFootball.TabStop = true;
            this.rdoFootball.Text = "Football";
            this.rdoFootball.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRegister.Location = new System.Drawing.Point(131, 318);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(217, 61);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register Now!";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // lblFeedbackText
            // 
            this.lblFeedbackText.AutoSize = true;
            this.lblFeedbackText.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackText.Location = new System.Drawing.Point(12, 425);
            this.lblFeedbackText.Name = "lblFeedbackText";
            this.lblFeedbackText.Size = new System.Drawing.Size(275, 16);
            this.lblFeedbackText.TabIndex = 14;
            this.lblFeedbackText.Text = "Please remember to register by the deadline!";
            this.lblFeedbackText.Click += new System.EventHandler(this.lblFeedbackText_Click);
            // 
            // imgBox
            // 
            this.imgBox.InitialImage = null;
            this.imgBox.Location = new System.Drawing.Point(374, 147);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(445, 276);
            this.imgBox.TabIndex = 15;
            this.imgBox.TabStop = false;
            // 
            // RegisterMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.lblFeedbackText);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rdoFootball);
            this.Controls.Add(this.rdoAmericanFootball);
            this.Controls.Add(this.rdoBasketball);
            this.Controls.Add(this.rdoBaseball);
            this.Controls.Add(this.rdoSkiing);
            this.Controls.Add(this.cmboState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "RegisterMember";
            this.Text = "Register Member";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmboState;
        private System.Windows.Forms.RadioButton rdoSkiing;
        private System.Windows.Forms.RadioButton rdoBaseball;
        private System.Windows.Forms.RadioButton rdoBasketball;
        private System.Windows.Forms.RadioButton rdoAmericanFootball;
        private System.Windows.Forms.RadioButton rdoFootball;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblFeedbackText;
        private System.Windows.Forms.PictureBox imgBox;
    }
}


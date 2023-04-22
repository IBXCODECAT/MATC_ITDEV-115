using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportingEventApp
{
    public partial class RegisterMember : Form
    {
        private string name = string.Empty;
        private string streetAddress = string.Empty;

        private enum SelectedSport 
        { 
            NOT_SELECTED,
            AMERICAN_FOOTBALL,
            BASEBALL,
            BASKETBALL,
            FOOTBALL,
            SKIING
        };

        private SelectedSport SELECTED_SPORT = SelectedSport.NOT_SELECTED;

        public RegisterMember()
        {
            InitializeComponent();

            rdoAmericanFootball.Click += RdoAmericanFootball_Click;
            rdoBaseball.Click += RdoBaseball_Click;
            rdoBasketball.Click += RdoBasketball_Click;
            rdoFootball.Click += RdoFootball_Click;
            rdoSkiing.Click += RdoSkiing_Click;

            btnRegister.Click += BtnRegister_Click;
            
        }

        #region RADIO_BUTTON_EVENTS
        private void RdoAmericanFootball_Click(object sender, EventArgs e)
        {
            SELECTED_SPORT = SelectedSport.AMERICAN_FOOTBALL;
            lblFeedbackText.Text = "Don't forget your shoulder pads!";
            imgBox.ImageLocation = "https://flagcdn.com/w320/us.png";
        }

        private void RdoBaseball_Click(object sender, EventArgs e)
        {
            SELECTED_SPORT = SelectedSport.BASEBALL;
            lblFeedbackText.Text = "Ready to play the game of America?";
            imgBox.ImageLocation = "https://flagcdn.com/w320/us.png";
        }

        private void RdoBasketball_Click(object sender, EventArgs e)
        {
            SELECTED_SPORT = SelectedSport.BASKETBALL;
            lblFeedbackText.Text = "Be sure to have plenty to drink!";
            imgBox.ImageLocation = "https://flagcdn.com/w320/lt.png";
        }

        private void RdoFootball_Click(object sender, EventArgs e)
        {
            SELECTED_SPORT = SelectedSport.FOOTBALL;
            lblFeedbackText.Text = "Remember, no shin kicking this year!";
            imgBox.ImageLocation = "https://flagcdn.com/w320/br.png";
        }

        private void RdoSkiing_Click(object sender, EventArgs e)
        {
            SELECTED_SPORT = SelectedSport.SKIING;
            lblFeedbackText.Text = "Please bring something warm, we don't need another hypothermia incident.";
            imgBox.ImageLocation = "https://flagcdn.com/w320/ru.png";
        }
        #endregion RADIO_BUTTON_EVENTS

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            bool textComponentsOK = !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtStreetAddress.Text) && !string.IsNullOrEmpty(txtCity.Text);
            bool radioButtonsOK = rdoAmericanFootball.Checked || rdoBaseball.Checked || rdoBasketball.Checked || rdoFootball.Checked || rdoSkiing.Checked;
            bool stateOK = !string.IsNullOrEmpty(cmboState.Text);

            if (textComponentsOK && stateOK && radioButtonsOK)
            {
                MessageBox.Show("You have successfully registered " + txtName.Text + " for " + SELECTED_SPORT.ToString() + "!", "Registration Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                txtStreetAddress.Clear();
                txtCity.Clear();
                rdoAmericanFootball.Checked = false;
                rdoBaseball.Checked = false;
                rdoBasketball.Checked = false;
                rdoFootball.Checked = false;
                rdoSkiing.Checked = false;
                cmboState.Text = string.Empty;
                imgBox.ImageLocation = "";

                lblFeedbackText.Text = "Please remember to register by the deadline!";
            }
            else
            {
                if (!radioButtonsOK)
                {
                    MessageBox.Show("Please specify a sport you wish to register for!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!stateOK)
                {
                    MessageBox.Show("Please select a state from the dropdown menu!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
                if(!textComponentsOK)
                {
                    MessageBox.Show("Your name or address has not been entered correctly!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            name = txtName.Text;
        }

        private void lblFeedbackText_Click(object sender, EventArgs e)
        {

        }
    }
}

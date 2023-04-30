using System;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class WindowsForm : Form
    {
        public WindowsForm()
        {
            InitializeComponent();

            infoToolStripMenuItem.Click += DisplayAssignmentInfoAsPopup;

            SetupContactDropdown();
        }

        /// <summary>
        /// Preloads the contact dropdown menu with the first and last names from the contacts db
        /// </summary>
        private void SetupContactDropdown()
        {
            //Read contacts and get the total amount we have
            int count = Contacts.ReadContacts();

            contactDropdown.Items.Clear();

            //For each contact we have found...
            for(int i = 0; i < count; i++)
            {
                //Add the last name of our contact to the dropdown menu
                contactDropdown.Items.Add($"{Contacts.GetFirstName(i)} {Contacts.GetLastName(i)}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// Displays assignment info in a message box
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">args</param>
        private void DisplayAssignmentInfoAsPopup(object sender, EventArgs e)
        {
            string msg = "Name:\t\tNathan Schmitt\nCourse:\t\tITDEV-115-001\nInstructor:\tJanese Christie\nAssignment:\tDB Assignment\nDate:\t\t" + DateTime.Now;
            MessageBox.Show(msg, "Contact App Assignment Thing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Called when the selected contact changed
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">args</param>
        private void SelectedContactChanged(object sender, EventArgs e)
        {
            inpFullName.Text = $"{Contacts.GetFirstName(contactDropdown.SelectedIndex)} {Contacts.GetLastName(contactDropdown.SelectedIndex)}";
            inpAddress.Text = $"{Contacts.GetAddress(contactDropdown.SelectedIndex)}";
            inpCity.Text = $"{Contacts.GetCity(contactDropdown.SelectedIndex)}";
            inpState.Text = $"{Contacts.GetState(contactDropdown.SelectedIndex)}";
            inpZip.Text = $"{Contacts.GetEmailAddress(contactDropdown.SelectedIndex)}";
            inpPhone.Text = $"{Contacts.GetPhoneNumber(contactDropdown.SelectedIndex)}";
            inpEmail.Text = $"{Contacts.GetEmailAddress(contactDropdown.SelectedIndex)}";
        }
    }
}

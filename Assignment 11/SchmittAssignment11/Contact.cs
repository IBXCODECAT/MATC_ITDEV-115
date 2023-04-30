using System;

namespace ContactsApp
{
    /// <summary>
    /// Responsible for storing contact data in memory
    /// </summary>
    
    [Serializable]
    public class Contact
    {
        #region FIELDS
        private string address;
        private string city;
        private string emailAddress;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string state;
        private string zipCode;
        #endregion FIELDS

        //Propreties have public sets due to the nature of deserialization
        #region PROPRETIES
        public string Address { internal get { return address; } set { address = value; } }
        public string City { internal get { return city; } set { city = value; } }
        public string EmailAddress { internal get { return emailAddress; } set { emailAddress = value; } }
        public string FirstName { internal get { return firstName;} set { firstName = value; } }
        public string LastName { internal get { return lastName;} set { lastName = value; } }
        public string PhoneNumber { internal get {  return phoneNumber; } set { phoneNumber = value; } }
        public string State { internal get { return state; } set { state = value; } }
        public string ZipCode { internal get { return zipCode; } set { zipCode = value; } }
        #endregion PROPRETIES

        /// <summary>
        /// Constructs a new Contact
        /// </summary>
        /// <param name="address">The address for this contact</param>
        /// <param name="city">The city for this contact</param>
        /// <param name="emailAddress">The email address for this contact</param>
        /// <param name="firstName">The first name for this contact</param>
        /// <param name="lastName">The last name for this contact</param>
        /// <param name="phoneNumber">The phone number for this contact</param>
        /// <param name="state">The state for this contact</param>
        /// <param name="zipCode">The zip code for this contact</param>
        public Contact(string address, string city, string emailAddress, string firstName, string lastName, string phoneNumber, string state, string zipCode)
        {
            this.address = address;
            this.city = city;
            this.emailAddress = emailAddress;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.state = state;
            this.zipCode = zipCode;
        }

        /// <summary>
        /// For some reason we have to add an empty constructor for the javascript deserilizer
        /// </summary>
        public Contact() { }
    }
}

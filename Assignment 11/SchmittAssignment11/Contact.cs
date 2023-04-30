using System;

namespace ContactsApp
{
    /// <summary>
    /// Responsible for storing contact data in memory
    /// </summary>
    
    [Serializable]
    internal class Contact
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

        #region PROPRETIES
        internal string Address { get { return address; } private set { address = value; } }
        internal string City { get { return city; } private set { city = value; } }
        internal string EmailAddress { get {  return emailAddress; } private set { emailAddress = value; } }
        internal string FirstName { get { return firstName;} private set { firstName = value; } }
        internal string LastName { get { return lastName;} private set { lastName = value; } }
        internal string PhoneNumber { get {  return phoneNumber; } private set { phoneNumber = value; } }
        internal string State { get { return state; } private set { state = value; } }
        internal string ZipCode { get { return zipCode; } private set { zipCode = value; } }
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
        internal Contact(string address, string city, string emailAddress, string firstName, string lastName, string phoneNumber, string state, string zipCode)
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
    }
}

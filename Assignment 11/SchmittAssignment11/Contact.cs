using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    internal class Contact
    {
        private string address;
        private string city;
        private string emailAddress;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string state;
        private string zipCode;

        internal string Address { get { return address; } }
        internal string City { get { return city; } }
        internal string EmailAddress { get {  return emailAddress; } }
        internal string FirstName { get { return firstName;} }
        internal string LastName { get { return lastName;} }
        internal string PhoneNumber { get {  return phoneNumber; } }
        internal string State { get { return state; } }
        internal string ZipCode { get { return zipCode; } }

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

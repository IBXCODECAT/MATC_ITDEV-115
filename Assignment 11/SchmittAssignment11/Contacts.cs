using System;
using System.Collections.Generic;
using System.IO;

using System.Web.Script.Serialization;

namespace ContactsApp
{
    /// <summary>
    /// Responsible for loading, deserializing, and accessing contact fields
    /// </summary>
    internal static class Contacts
    {
        /// <summary>
        /// The location that the contacts save file is stored on disk
        /// </summary>
        private const string fileName = @"contacts.json";

        /// <summary>
        /// An array to store our contacts once we deserialize them
        /// </summary>
        private static Contact[] contacts;

        #region GETTERS

        /// <summary>
        /// Getter method
        /// </summary>
        /// <param name="index">The index of the contact to get</param>
        /// <returns>The address for the specified contact</returns>
        internal static string GetAddress(int index)
        {
            return contacts[index].Address;
        }

        /// <summary>
        /// Getter method
        /// </summary>
        /// <param name="index">The index of the contact to get</param>
        /// <returns>The city for the specified contact</returns>
        internal static string GetCity(int index)
        {
            return contacts[index].City;
        }

        /// <summary>
        /// Getter method
        /// </summary>
        /// <param name="index">The index of the contact to get</param>
        /// <returns>The email address for the specified contact</returns>
        internal static string GetEmailAddress(int index)
        {
            return contacts[index].EmailAddress;
        }

        /// <summary>
        /// Getter method
        /// </summary>
        /// <param name="index">The index of the contact to get</param>
        /// <returns>The first name for the specified contact</returns>
        internal static string GetFirstName(int index)
        {
            return contacts[index].FirstName;
        }

        /// <summary>
        /// Getter method
        /// </summary>
        /// <param name="index">The index of the contact to get</param>
        /// <returns>The last name for the specified contact</returns>
        internal static string GetLastName(int index)
        {
            return contacts[index].LastName;
        }

        /// <summary>
        /// Getter method
        /// </summary>
        /// <param name="index">The index of the contact to get</param>
        /// <returns>The phone number for the specified contact</returns>
        internal static string GetPhoneNumber(int index)
        {
            return contacts[index].PhoneNumber;
        }

        /// <summary>
        /// Getter method
        /// </summary>
        /// <param name="index">The index of the contact to get</param>
        /// <returns>The state for the specified contact</returns>
        internal static string GetState(int index)
        {
            return contacts[index].State;
        }

        /// <summary>
        /// Getter method
        /// </summary>
        /// <param name="index">The index of the contact to get</param>
        /// <returns>The zip code for the specified contact</returns>
        internal static string GetZip(int index)
        {
            return contacts[index].ZipCode;
        }

        #endregion GETTERS

        /// <summary>
        /// Reads the contacts serialized as JSON from disk and deserializes them into the Contact array
        /// </summary>
        /// <returns>The number of contacts found</returns>
        internal static int ReadContacts()
        {
            string jsonData = string.Empty;
            List<Contact> contacts = new List<Contact>();

            try
            {
                jsonData = File.ReadAllText(fileName);
            }
            catch (Exception) { return 0; }

            if(!string.IsNullOrEmpty(jsonData))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                contacts = serializer.Deserialize<List<Contact>>(jsonData);
            }

            return contacts.Count;
        }
    }
}

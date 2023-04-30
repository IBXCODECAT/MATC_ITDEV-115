using System;
using System.Collections.Generic;
using System.IO;

using System.Web.Script.Serialization;

namespace ContactsApp
{
    internal static class Contacts
    {
        private const string fileName = @"contacts.json";

        internal static int ReadContacts()
        {
            string jsonData = string.Empty;
            List<Contact> contacts = new List<Contact>();

            try
            {
                jsonData = File.ReadAllText(fileName);
            }
            catch (Exception) { }

            if(!string.IsNullOrEmpty(jsonData))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                contacts = serializer.Deserialize<List<Contact>>(jsonData);
            }

            return contacts.Count;
        }
    }
}

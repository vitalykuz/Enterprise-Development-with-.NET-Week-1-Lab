using System;
using System.Collections.Generic;

namespace Week_1_Address_Book
{
    public class AddressBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public void PrintContacts()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine("Contact name: {0} " +
                                  "\n Contact Phone Number: {1}",
                                  contact.Name,
                                  contact.PhoneNumber);
            }
        }

        public Contact SearchContact(string contactName)
        {
            foreach (var contact in Contacts)
            {
                if (contact.Name.Equals(contactName))
                {
                    return contact;
                }
            }
            return null;
        }

        public void DeleteContact(string contactName)
        {
            foreach (var contact in Contacts)
            {
                
            }
        }
    }
}
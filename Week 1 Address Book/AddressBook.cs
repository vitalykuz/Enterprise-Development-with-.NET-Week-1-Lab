using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Week_1_Address_Book
{
    [Serializable]
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

        public void PrintContact(Contact contact)
        {
            Console.WriteLine("Contact name: {0} " +
                                  "\n Contact Phone Number: {1}",
                                  contact.Name,
                                  contact.PhoneNumber);
        }

        public Contact SearchContactWithLINQ(string contactName)
        {
            var listOfContacts = from contact in Contacts
                                 where contact.Name.Equals(contactName)
                                select contact;

            foreach (var contact in listOfContacts)
            {
                if (contact != null)
                {
                    return contact;
                }
                
            }

            return null;
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

        public bool DeleteContactWithLinq(string contactName)
        {

            var listOfContacts = from contact in Contacts
                                 where contact.Name.Equals(contactName)
                                 select contact;

            foreach (var contact in listOfContacts)
            {
                if (contact != null)
                {
                    Contacts.Remove(contact);
                    return true;
                }

            }
            return false;
        }

        public bool DeleteContact(string contactName)
        {

            foreach (var contact in Contacts)
            {
                if (contact.Name.Equals(contactName))
                {
                    Contacts.Remove(contact);
                    return true;
                }
            }
            return false;
        }

        public void FunWithLinq()
        {
            StringBuilder stringBuilder = new StringBuilder();

            var contacts = from contact in Contacts
                where contact.Id > 4
                select contact;

            foreach (var contact in contacts)
            {
                stringBuilder.Append(contact.Name + Environment.NewLine);
            }
            Console.WriteLine(stringBuilder.ToString());
        }


        public void Edit()
        {
            Console.Write("Please type the name of the contact you want to edit: ");
            var contactName = Console.ReadLine();

            var contact = SearchContactWithLINQ(contactName);

            if (contact != null)
            {
                Console.Write("Please type a new name: ");
                contact.Name = Console.ReadLine();
                Console.Write("Successfully changed the name!");
            }
            else
            {
                Console.WriteLine("No such client");
            }
        }
    }
}
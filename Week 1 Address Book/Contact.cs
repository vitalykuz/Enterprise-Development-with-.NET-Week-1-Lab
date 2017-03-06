using System;

namespace Week_1_Address_Book
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactType { get; set; }

        public Contact(string name, string phoneNumber, string contactType, int id)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            ContactType = contactType;
            Id = id;
        }
    }
}
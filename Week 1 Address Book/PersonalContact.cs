using System;

namespace Week_1_Address_Book
{
    public class PersonalContact : Contact
    {
        public string Address { get; set; }

        public PersonalContact(string name, string phoneNumber, string address) 
            : base(name, phoneNumber)
        {
            Address = address;
        }
    }
}
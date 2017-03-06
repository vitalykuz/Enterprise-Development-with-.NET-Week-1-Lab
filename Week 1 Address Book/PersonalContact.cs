using System;

namespace Week_1_Address_Book
{
    [Serializable]
    public class PersonalContact : Contact
    {
        public string Address { get; set; }

        public PersonalContact(string name, string phoneNumber, string address, string contactType, int id) 
            : base(name, phoneNumber, contactType, id)
        {
            Address = address;
        }
    }
}
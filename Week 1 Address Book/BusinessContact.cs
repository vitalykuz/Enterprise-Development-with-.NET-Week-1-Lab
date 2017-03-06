using System;

namespace Week_1_Address_Book
{
    [Serializable]
    public class BusinessContact : Contact
    {
        public string CompanyName { get; set; }
        public string FaxNumber { get; set; }
        
        public BusinessContact(string name, string phoneNumber, string companyName, string faxNumber, string contactType, int id) 
            : base(name, phoneNumber, contactType, id)
        {
            CompanyName = companyName;
            FaxNumber = faxNumber;
        }
    }
}
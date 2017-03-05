namespace Week_1_Address_Book
{
    public class BusinessContact : Contact
    {
        public string CompanyName { get; set; }
        public string FaxNumber { get; set; }

        public BusinessContact(string name, string phoneNumber, string companyName, string faxNumber) 
            : base(name, phoneNumber)
        {
            CompanyName = companyName;
            FaxNumber = faxNumber;
        }
    }
}
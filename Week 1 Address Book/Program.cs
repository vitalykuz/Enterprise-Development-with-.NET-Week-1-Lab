/*
 * 
 * Week 1 Lab
    Lab exercise: Address Book
    Week 1: Address Book Exercise

    Address book

    Requirements

    You are required to produce a working console program that can store and manage a simple address book.
    
    The program will support the following functionality:

        Add a new contact to the book
        List the contacts in the book
        Search for contacts by name
    
    Two different kinds of contacts exist. 

        Personal contacts have the following attributes:

            Name
            Address
            Phone number

        Business contacts have the following attributes:

            Name
            Company
            Phone number
            Fax number

    Additional functionality

    You can optionally add the following functionality to the program:

        Delete a contact from the book, given its name
        Edit the information of a contact in the book, given its name
        Save/load the address book to/from a disk file
    
    Hints

    Even though it is possible to use a procedural approach to solve this problem, 
    for this exercise you MUST use inheritance and polymorphism!

    Use a collection from System.Collections.Generic for type safety

    Use LINQ to query the collection of contacts.

    In order to persist data to a disk file, you can use object serialization or an XML reader/writer
    in System.Xml

     * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Address_Book
{
    class Program
    {
        private static readonly AddressBook AddressBook = new AddressBook();
        private static readonly Menu Menu = new Menu();

        static void Main(string[] args)
        {
            GenerateData();
            Menu.StartingGreeting();
            var userInput = ReadInput();
            while (userInput != "exit")
            {
                ApplyUserOption(userInput);
                userInput = ReadInput();
            }
            
       
            Console.Read();
        }

        private static void ApplyUserOption(string userInput)
        {
            switch (userInput)
            {
                case "add":
                    AddContact();
                    break;
                case "find":
                    FindContact();
                    break;
                case "print":
                    AddressBook.PrintContacts();
                    break;
                case "delete":
                    DeleteContact();
                    break;
                case "edit":
                    break;
                case "save":
                    break;
                case "load":
                    break;
                case "show":
                    Menu.ShowMenu();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No such option");
                    break;                                   
            }
        }

        public static void AddContact()
        {
            Console.WriteLine("What would be the name of the contact");
            var contactName = Console.ReadLine();
            Console.WriteLine("What would be the phone number of the contact");
            var phoneNumber = Console.ReadLine();

            var newContact = new Contact(contactName, phoneNumber);
            AddressBook.AddContact(newContact);
            Console.WriteLine("Contact is added!");
        }

        public static void FindContact()
        {
            Console.Write("Name of the contact: ");
            var contactNameFromUser = Console.ReadLine();
            var contact = AddressBook.SearchContact(contactNameFromUser);
            if (contact != null)
            {
                AddressBook.PrintContact(contact);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public static void DeleteContact()
        {
            Console.Write("Name of the contact: ");
            var contactNameFromUser = Console.ReadLine();
            var isDeleted = AddressBook.DeleteContact(contactNameFromUser);
            if (isDeleted)
            {
                Console.WriteLine("Successfully deleted");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        private static string ReadInput()
        {
            Menu.ShowMenu();
            Console.Write("Please choose an option ");
            string userInput = Console.ReadLine();
            userInput.ToLower();
  
            return userInput;
        }

        public static void GenerateData()
        {
            //creates 3 different contacts
            var personalContact = new PersonalContact("Tanya", "03-04-114", "Liverpool Road");
            var businessContact = new BusinessContact("Alexis", "04-118-232", "MadPaws", "986-542");
            var contact = new Contact("Vova", "853-122");

            //adds contacts to the Address Book
            AddressBook.AddContact(personalContact);
            AddressBook.AddContact(businessContact);
            AddressBook.AddContact(contact);
        }

    }
}

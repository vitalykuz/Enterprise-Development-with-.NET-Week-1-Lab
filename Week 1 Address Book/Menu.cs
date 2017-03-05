using System;

namespace Week_1_Address_Book
{
    public class Menu
    {
        public void StartingGreeting()
        {
            Console.WriteLine("Hello to the Address Book!");
            Console.WriteLine("Please check out the menu: ");
        }

        public void ShowMenu()
        {
            Console.WriteLine("The menu options are folowwing: \n" +
                              "Add - Add a contact \n" +
                              "Find - Find a contact by name \n" +
                              "Print - Print all contacts \n" +
                              "Delete - Delete a contact by name \n" +
                              "Edit - Edit a contact \n" +
                              "Save - Save the address book to a file \n" +
                              "Load - Load the address book from a file \n" +
                              "Show - Show menu options \n" +
                              "Exit - Exit the program");
        }
    }
}
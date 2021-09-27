using System;
using System.Text;

namespace AddressBookNew
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Address Book Program ");
            AddressBook_UC1 addressClass = new AddressBook_UC1();
	    AddressBook_UC1.AddContact();
	    AddressBook_UC1.displayContact();
	}
    }
}


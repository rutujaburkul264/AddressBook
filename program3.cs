using System;
using System.Text;

namespace AddressBookNew
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Address Book Program ");
            // AddressBook_UC1 person = new AddressBook_UC1();
            int find = 0;
            while (find == 0)
            {
                Console.WriteLine("1:Add  2:Display  3:Edit  4:Delete");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddressBook_UC1.AddContact();
                        break;
                    case 2:
                        AddressBook_UC1.displayContact();
                        break;
                    case 3:
                        Console.WriteLine("Enter the FirstName and LastName for edit");
                        string firstName = Console.ReadLine();
                        string lastName = Console.ReadLine();
                        AddressBook_UC1.editContact(firstName, lastName);
                        break;
                    default:
                        find++;
                        break;
                }

            }

        }
    }
}

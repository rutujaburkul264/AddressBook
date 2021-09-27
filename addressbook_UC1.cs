using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookNew
{
    class AddressBook_UC1
    {

        public String firstName, lastName, address, city, state, email;
        public int zip;
        public long phoneNumber;

        public static List<AddressBook_UC1> ListContact = new List<AddressBook_UC1>();
        /*
        Used getter and setter to set and get the value.
        Setter is used to set the value
        Getter is used to get the value
         */

        public String getfirstName()
        {
            return firstName;
        }

        public void setfirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getlastName()
        {
            return lastName;
        }

        public void setlastName(String lastName)
        {
            this.lastName = lastName;
        }

        public String getaddress()
        {
            return address;
        }

        public void setaddress(String address)
        {
            this.address = address;
        }

        public String getcity()
        {
            return city;
        }

        public void setcity(String city)
        {
            this.city = city;
        }

        public String getstate()
        {
            return state;
        }

        public void setstate(String state)
        {
            this.state = state;
        }

        public String getemail()
        {
            return email;
        }

        public void setemail(String email)
        {
            this.email = email;
        }

        public int getzip()
        {
            return zip;
        }

        public void setzip(int zip)
        {
            this.zip = zip;
        }

        public long getphoneNumber()
        {
            return phoneNumber;
        }

        public void setphoneNumber(long phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    

        public static void AddContact()
        {
           
            Console.WriteLine("The following contact details is mentioned below : \n");
            Console.Write("First Name : ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name  : ");
            string lastName = Console.ReadLine();
            Console.Write("Address    : ");
            string address = Console.ReadLine();
            Console.Write("City       : ");
            string city = Console.ReadLine();
            Console.Write("State      : ");
            string state = Console.ReadLine();
            Console.Write("E-mail     : ");
            string email = Console.ReadLine();
            Console.Write("Zip Code   : ");
            int zip = int.Parse(Console.ReadLine());
            Console.Write("Phone Number   : ");
            long phoneNumber = long.Parse(Console.ReadLine());
            ListContact.Add(new AddressBook_UC1()
            {
                firstName = firstName,
                lastName = lastName,
                address = address,
                city = city,
                state = state,
                email = email,
                zip = zip,
                phoneNumber = phoneNumber
            });;
        }
    }
}

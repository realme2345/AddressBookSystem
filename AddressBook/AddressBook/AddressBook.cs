using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    /// <summary>
    /// Address Book
    /// </summary>
    class AddressBook
    {
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string State;
        public string City;
        public string ZipCode;
        public string Addresses;
        // Creating a constructer 
        public AddressBook(string firstName, string lastName, string phoneNumber, string state, string city, string zipCode, string addresses)
        {
            this.FirstName = firstName; //Assigning data
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.State = state;
            this.City = city;
            this.ZipCode = zipCode;
            this.Addresses = addresses;
        }
    }
}
   



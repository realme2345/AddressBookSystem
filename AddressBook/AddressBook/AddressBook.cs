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
    internal class AddressBook
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string PhoneNumber { get; set; }
        private string[] Addresses { get; set; }

        public static List<AddressBook> People = new List<AddressBook>();
        // creating list for to store the all address of people

        public static void AddPerson()  //creating metod for a class
        {
            AddressBook person = new AddressBook(); // creating a object for to access instance method or variable

            Console.Write("Enter First Name: "); // Taking the inputs from user
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Address 1: ");
            string[] addresses = new string[2]; // creating Array for to store the address
            addresses[0] = Console.ReadLine();
            Console.Write("Enter Address 2 (Optional): ");
            addresses[1] = Console.ReadLine();
            person.Addresses = addresses;

            People.Add(person);
        }
        /// <summary>
        /// Displaying the Welcome message 
        /// </summary>
        private static void PrintPerson(AddressBook person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address 1: " + person.Addresses[0]);
            Console.WriteLine("Address 2: " + person.Addresses[1]);
            Console.WriteLine("-------------------------------------------");
        }
        public static void ListPeople() //This method used to show people who are present in Address book
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var Element in People)
            {
                PrintPerson(Element);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.uc4
{
    /// <summary>
    /// Address Book
    /// </summary>
    internal class UC4AddressBook
    {/// <summary>
    /// Ability to add and remove persons with respect to their names
    /// </summary>
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string PhoneNumber { get; set; }
        private string[] Addresses { get; set; }

        public static List<UC4AddressBook> People = new List<UC4AddressBook>();
        // creating list for to store the all address of people
        public static void AddPerson()    //creating metod for a class
        {
            
            UC4AddressBook person = new UC4AddressBook();   // creating a object for to access instance method or variable

            Console.Write("Enter First Name: ");   // Taking the inputs from user
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Address 1: ");
            string[] addresses = new string[2];  // creating Array for to store the address
            addresses[0] = Console.ReadLine();
            Console.Write("Enter Address 2 (Optional): ");
            addresses[1] = Console.ReadLine();
            person.Addresses = addresses;

            People.Add(person);
        }
        public static void PrintPerson(UC4AddressBook person)
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
        public static void RemovePerson() //this method for remove the people with respect their names
        {
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string firstName = Console.ReadLine();
            UC4AddressBook person = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            PrintPerson(person);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                People.Remove(person);
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();
            }
        }

    }
}


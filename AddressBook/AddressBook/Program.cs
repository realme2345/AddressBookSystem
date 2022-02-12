using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {/// <summary>
     ///Address Book
     /// </summary>
     /// <param name="args"></param>
        public static Dictionary<string,AddressBook> people = new Dictionary<string, AddressBook>();
        static void Main(string[] args) //Ability to add multiple person to address book and stored in Dictionaries
        {
            Console.WriteLine(" Add Person :");
            int num = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            while (x <= num)
            {
                AddPerson();
                x++;
            }
            ListPeople();
            SearchPerson(people);
        }
        public static void AddPerson()//method for adding multiple members
        {
                AddressBook person = new AddressBook(); // creating a object for to access instance method or variable
                Console.Write("Enter First Name: "); // Taking the inputs from user
                person.FirstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();
                Console.Write("Enter Phone Number: ");
                person.PhoneNumber = Console.ReadLine();
                Console.Write("Enter Address 1: ");
                person.Addresses = Console.ReadLine();
                Console.WriteLine("Enter State");
                person.State = Console.ReadLine();
                Console.WriteLine("Enter a City");
                person.City = Console.ReadLine();
                Console.WriteLine("Enter the Zip Code");
                person.ZipCode = Console.ReadLine();
                people.Add(person.City, person);// adding the peoples to the Dictionaries
        }

        public static void PrintPerson(AddressBook person)//this method to print the persons
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address : " + person.Addresses);
            Console.WriteLine("State : " + person.State);
            Console.WriteLine("City : " + person.City);
            Console.WriteLine("ZipCode :" + person.ZipCode);
            Console.WriteLine("-------------------------------------------");
        }
        public static void ListPeople() //This method used to show people who are present in Address book
        { 
            if (people.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var Element in people.Values)
            {
                PrintPerson(Element);
            }
        }
        public static void SearchPerson(Dictionary<string, AddressBook> people) //this method for search the people with respect their names
        {
            Console.WriteLine("Enter the City name of the person you would like to Know:");
            string city = Console.ReadLine();
            people.ContainsKey(city);
            try
            {
                foreach (var Element in people)
                {
                    PrintPerson(Element.Value);
                }
                Console.WriteLine(people.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

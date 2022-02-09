using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {/// <summary>
     /// Employee Wage
     /// </summary>
     /// <param name="args"></param>
        public static List<AddressBook> list = new List<AddressBook>();
        static void Main(string[] args) //Ability to add multiple person to address book and stored in Dictionaries
        {
            AddPerson();
            //AddPerson();
            ListPeople();
            SearchPerson();
        }
        public static void AddPerson()//method for adding multiple members
        {
            list.Add(new AddressBook("Raja",
                                     "Kongara",
                                     "9133139939",
                                     "Telanagana",
                                     "HYD",
                                     "507143",
                                       "ASDR"));
            list.Add(new AddressBook("Nari",
                                     "Gaggilla",
                                     "9133139939",
                                     "Telanagana",
                                     "VJW",
                                     "507022",
                                       "ASD"));
            list.Add(new AddressBook("Nagi", "Gajjella", "89826336522", "Telanagan", "Khamma", "507122", "shdhd"));
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
            if (list.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var Element in list)
            {
                PrintPerson(Element);
            }
        }
        public static void SearchPerson() //this method for search the people with respect their names
        {
            Console.WriteLine("Enter the City name of the person you would like to Know:");
            string city = Console.ReadLine();
            AddressBook person = list.FirstOrDefault(x => x.City.ToLower() == city.ToLower());
            while (person != null)
            {
                Console.WriteLine("Person is present succefull");
                PrintPerson(person);
                Console.ReadKey();
                return;
            }
            if (person == null)
            {
                Console.WriteLine("Person is not present");
            }
        }
    }
}

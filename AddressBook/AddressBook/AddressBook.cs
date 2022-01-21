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
        /// <summary>
        /// Displaying the Welcome message 
        /// </summary>
        public static void DispalyAddress() //creating moethod for a class
        {
            Console.Write("Enter First Name: "); //Taking the inputs from user
            Console.ReadLine();
            Console.Write("Enter Last Name: ");
            Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            Console.ReadLine();
            Console.Write("Enter Address 1: ");
            string[] addresses = new string[2]; // creating Array for to store the address
            addresses[0] = Console.ReadLine();
            Console.Write("Enter Address 2 (Optional): ");
            addresses[1] = Console.ReadLine();
            foreach (string element in addresses)
            {
                Console.WriteLine(element);

            }
        }
    }
}

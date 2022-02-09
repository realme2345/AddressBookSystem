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
        static void Main(string[] args) //Ability to add multiple person to address book and stored in Dictionaries
        {
            Console.WriteLine("Enter a Number of Address to Add :");
            int n=Convert.ToInt32(Console.ReadLine());
            AddressBook.AddPerson();
            int i = 1;
            while (i <= n)
            {
                try
                {
                    AddressBook.DublicatePerson();//this method for avoid dublicate persons in address book
                    i++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            AddressBook.ListPeople();
        }
    }
}

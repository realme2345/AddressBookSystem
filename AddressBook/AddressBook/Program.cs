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
        static void Main(string[] args) //Ability to add multiple person to address book
        {
            Console.WriteLine(" Add Person :");
            int num = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            while (x <= num)
            {
                AddressBook.AddPerson();
                x++;
            }
            AddressBook.ListPeople();
        }
    }
}

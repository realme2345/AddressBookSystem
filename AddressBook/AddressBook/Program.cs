using System;
using System.Collections.Generic;
using System.IO;
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
        static void Main(string[] args) //Ability to add multiple person to address book and stored in Dictionaries
        {
            //AddressBook.AddPerson();
            //AddressBook.ListPeople();
            //AddressBook.SortedBasedOnCity();
            //AddressBook.SortedBasedOnState();
            // this method for Reading the Data from The File
            string path = @"D:\git\AddressBook\AddressBookSystem\AddressBook\AddressBook\AddressBook.cs";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
    }
}

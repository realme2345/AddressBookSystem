using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;

namespace AddressBook
{
    internal class Program
    {/// <summary>
     ///Address Book
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args) //Ability to add multiple person to address book and stored in Dictionaries
        {
            AddressBook.AddPerson();
            AddressBook.ListPeople();
            AddressBook.SortedBasedOnCity();
            AddressBook.SortedBasedOnState();
            Console.WriteLine("Reading the Data");
            CsvData();
        }
        public static void CsvData()
        {
            string path = @"D:\git\AddressBook\AddressBookSystem\AddressBook\AddressBook\AddressBook.cs";
            //List<AddressBook> addressBook=JsonConvert.DeserializeObject<List<AddressBook>>(File.ReadAllText(path));
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecord<AddressBook>().ToString();
                Console.WriteLine("Read the Data succefully from the file");
                foreach (var address in records)
                {
                    Console.WriteLine(address.ToString());
                }
            }

        }
    }
}

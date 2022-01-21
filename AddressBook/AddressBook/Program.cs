using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a command : 1=add,2=remove,3=list");

            int num =Convert.ToInt32(Console .ReadLine()); 
            
                switch(num)
                {
                    case 1:
                    AddressBook.AddPerson();
                    break;
                    case 2:
                    AddressBook.RemovePerson();
                    break ;
                    case 3:
                    AddressBook.ListPeople();
                    break ;
                }
            Console.Read();
        }
    }
}

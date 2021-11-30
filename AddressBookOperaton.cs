using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Address_Book
{
    class AddressBookOperaton
    {

        private static Dictionary<string, Contact> address_book = new Dictionary<string, Contact>();
        public static Dictionary<string, Dictionary<string, object>> AddressBook = new Dictionary<string, Dictionary<string, object>>();

        public static void AddContact(string bookname )
        {

            Contact contact = new Contact();
            Console.Write("Enter First Name : ");
            string FirstName = Console.ReadLine();
            if (AddressBook[bookname].ContainsKey(FirstName))
            {
             Console.WriteLine("Person Name is already exist please enter different name");
            }
            else
            { 
                contact.FirstName = FirstName;

                Console.Write("Enter Last Name : ");
                contact.LastName = Console.ReadLine();


             /*   Console.Write("Enter Address : ");
                contact.Address = Console.ReadLine();*/

                Console.Write("Enter City : ");
                contact.City = Console.ReadLine();

               Console.Write("Enter State : ");
                contact.State = Console.ReadLine();

               /* Console.Write("Enter Zip code : ");
                contact.Zip = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Phone Number : ");
                contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

                Console.Write("Enter the Email: ");
                contact.Email = Console.ReadLine();*/
                Console.WriteLine("--------------------------------------------");


                AddressBook[bookname].Add(contact.FirstName, contact);
            }
          
        }

        public static void Update(string bookname)
        {
            Console.Write("For update Enter the Person name:");
            string Input = Console.ReadLine();

            if (AddressBook[bookname].ContainsKey(Input))
            {
                AddContact(bookname);
            }
            else
            {
                Console.WriteLine("Record not found!");
            }


        }
        public static void Remove(string bookname)
        {
            Console.Write("Enter the Person name You want to Remove:");
            string Input = Console.ReadLine();
            if (AddressBook[bookname].ContainsKey(Input))
            {
                AddressBook[bookname].Remove(Input);
                Console.WriteLine("Remove Successfully!");
            }
            else
            {
                Console.WriteLine("Record not found!");
            }

        }

        public static void PrintPerson(string AdderssBookname)
        {
            foreach (Contact contact in AddressBook[AdderssBookname].Values)
            {
                Console.WriteLine("");
                Console.WriteLine("First Name: " + contact.FirstName);
                Console.WriteLine("Last Name: " + contact.LastName);
               // Console.WriteLine("Address : " + contact.Address);
                Console.WriteLine("City : " + contact.City);
                Console.WriteLine("State : " + contact.State);
               /* Console.WriteLine("Zip : " + contact.Zip);
                Console.WriteLine("PhoneNumber : " + contact.PhoneNumber);
                Console.WriteLine("Email : " + contact.Email);*/
                Console.WriteLine("--------------------------------------------");
            }
        }

        public void addAddressbook(string AdderssBookname)
        {
            var address_book = new Dictionary<string, object>();
            AddressBook.Add(AdderssBookname, address_book);
        }

        public static void search_person()
        {
            Console.WriteLine("Enter the city that you want to search");
            string cityname  = Console.ReadLine();
            Console.WriteLine("Enter the state that you want to search");
            string statename  = Console.ReadLine();
            /*   foreach(string addressbook in  AddressBook.Keys)
               foreach (address_book in AddressBook[AdderssBookname].Where(e => (e.Value.City == cityname.ToLower()) || (e.State == statename.ToLower())))
               {


               }*/
            foreach (string AddressBookName in AddressBook.Keys)
            {
                foreach (Contact contact in AddressBook[AddressBookName].Values)
                {
                    if (cityname.ToLower() == contact.City || statename.ToLower() == contact.State)
                    {
                        Console.WriteLine("In address book {0}, {1} is staying in {2} city and {3} state", AddressBookName, contact.FirstName, contact.City, contact.State);
                    }
                }
            }
        }

        public static Dictionary<string, Dictionary<string, object>> Return_AddressBook()
        {
            return AddressBook;
        }
    }
}

using System;
using System.Collections.Generic;
namespace Address_Book
{
    class Program
    {
        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int Zip { get; set; }

            public long PhoneNumber { get; set; }

            public string Email { get; set; }
        }

        private static void AddContact()
        {
            Contact contact = new Contact();

            Console.Write("Enter First Name : ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name : ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter City : ");
            contact.City = Console.ReadLine();

            Console.Write("Enter State : ");
            contact.State = Console.ReadLine();

            Console.Write("Enter Zip code : ");
            contact.Zip = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Phone Number : ");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter the Email: ");
            contact.Email = Console.ReadLine();
            Address_book.Add(contact);
        }

       

        private static void PrintPerson(Contact contact)
        {

            Console.WriteLine("");
            Console.WriteLine("First Name: " + contact.FirstName);
            Console.WriteLine("Last Name: " + contact.LastName);
            Console.WriteLine("Address : " + contact.Address);
            Console.WriteLine("City : " + contact.City);
            Console.WriteLine("State : " + contact.State);
            Console.WriteLine("Zip : " + contact.Zip);
            Console.WriteLine("PhoneNumber : " + contact.PhoneNumber);
            Console.WriteLine("Email : " + contact.Email);

        }

        public static List<Contact> Address_book = new List<Contact>();
        static void Main(string[] args)
        {
            Contact obj = new Contact();

            Console.Write("how many new contacts you wants to add :");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N > 0)
            {
                Console.WriteLine("Enter the Contact details :-");
                AddContact();
                N--;
            }
            PrintPerson(Address_book[0]);

        }
    }
}


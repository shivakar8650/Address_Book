using System;
using System.Collections.Generic;
using System.Linq;

namespace Address_Book
{
    class Program
    {
        public static int check_update = 0;
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

        private static void AddContact(Contact contact)
        {
           // Contact contact = new Contact();

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
            Console.WriteLine("--------------------------------------------");
          
            if(check_update==0)
                Address_book.Add(contact);
        }

        private static void update()
        {
            Console.Write("For update Enter the Person name:");
            string Input =Console.ReadLine();
            check_update = 1;
           Contact person = Address_book.FirstOrDefault(x => x.FirstName.ToLower() == Input.ToLower());
            AddContact(person);
           
            Console.WriteLine("The entered details are :");
            PrintPerson(person);

         
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
            Console.WriteLine("--------------------------------------------");
        }

        public static List<Contact> Address_book = new List<Contact>();
        static void Main(string[] args)
        {
           

            Console.Write("how many new contacts you wants to add :");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N > 0)
            {
                Contact person = new Contact();
                Console.WriteLine("Enter the Contact details :-");
                AddContact(person);
                N--;
            }
         
            update();

            Console.WriteLine("All contact are :-");
            foreach (var print in Address_book)
            {
                PrintPerson(print);
            }
        }
    }
}


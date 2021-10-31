using System;
using System.Collections.Generic;
using System.Linq;

namespace Address_Book
{
    class Program
    { public static int check_update = 0;
     
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
            

            Console.Write("Enter First Name : ");
            string FirstName = Console.ReadLine();
            if (Address_book.ContainsKey(FirstName))
            {
                Console.WriteLine("Person Name is not valid please enter unique name");
                
            }
            else
            {

                contact.FirstName = FirstName;

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

                if (check_update == 0)
                    Address_book.Add(contact.FirstName, contact);
            } 
        }

        private static void Update()
        {
            Console.Write("For update Enter the Person name:");
            string Input = Console.ReadLine();
            check_update = 1;
            if (Address_book.ContainsKey(Input))
            {
              AddContact((Contact)Address_book[Input]);
            }
            else
            {
                Console.WriteLine("Record not found!");
            }

            
        }

        private static void Remove()
        {
            Console.Write("Enter the Person name You want to Remove:");
            string Input = Console.ReadLine();
            if (Address_book.ContainsKey(Input))
            {
                Address_book.Remove(Input);
                Console.WriteLine("Remove Successfully!");
            }
            else
            {
                Console.WriteLine("Record not found!");
            }
         
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
        public static Dictionary<string, object> Address_book = new Dictionary<string, object>();
       
        static void Main(string[] args)
        {
            char input = 'Y';
            while (input != 'N')
            {
                check_update = 0;
                Console.Write("Choose the Any one Option : \n 1.for Add : \n 2.for Update :\n 3.for Remove :\n 4.for Print : \n Enter the choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("how many new contacts you wants to add :");
                    int N = Convert.ToInt32(Console.ReadLine());
                    while (N > 0)
                    {
                        Contact person = new Contact();
                        Console.WriteLine("Enter the Contact details :-");
                        AddContact(person);
                        N--;
                    }
                    break;
                case 2:
                    Update();
                    break;
                case 3:
                    Remove();
                    break;
                case 4:
                    Console.WriteLine("All contact are :-");
                    foreach (var print in Address_book)
                    {
                  
                             PrintPerson((Contact)print.Value);
                    }
                    break;
                default:
                    Console.WriteLine("invalid input! enter again:");
                    break;

            }

            Console.Write("For Continue/Quit press (Y/N) \n Enter the Key:");
            input = Convert.ToChar(Console.ReadLine());
             
            } 
            

            
        }
    }
}


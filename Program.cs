using System;
using System.Collections.Generic;
using System.Linq;

namespace Address_Book
{


    class Program
    {
        static void Main(string[] args)
        {
            AddressBookOperaton operaton = new AddressBookOperaton();
            string AdderssBookname = "existing";

            Console.WriteLine("Choose any one \n 1.For existing Address book \n 2.Create new Address book");
            var choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    operaton.addAddressbook(AdderssBookname);
                    break;
                case 2:
                    {
                        Console.WriteLine("enter the new address book name");
                        AdderssBookname = Console.ReadLine();
                        operaton.addAddressbook(AdderssBookname);
                    }
                    break;
                default:
                    Console.WriteLine("invalid input!");
                    break;
            }
            char input = 'Y';
            while (input != 'N')
            {
                Console.Write("Choose the Any one Option : \n 1.for Add : \n 2.for Update :\n 3.for Remove :\n 4.for Print : \n 5.add new addressBook : \n 6.switch to other addressbook : \n Enter the choice:");
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
                            AddressBookOperaton.AddContact(AdderssBookname);
                            N--;
                        }
                        break;
                    case 2:
                         AddressBookOperaton.Update(AdderssBookname);
                        break;
                    case 3:
                        AddressBookOperaton.Remove(AdderssBookname);
                        break;
                    case 4:
                        Console.WriteLine("All contact are :-");
                        AddressBookOperaton.PrintPerson(AdderssBookname);
                        break;
                    case 5:
                        Console.WriteLine("Enter Name For New AddressBook");
                        AdderssBookname = Console.ReadLine();
                        operaton.addAddressbook(AdderssBookname);
                        Console.WriteLine(" Switch to " + AdderssBookname);
                      
                        break;
                    case 6:
                        Console.WriteLine("Enter Name Of AddressBook From Below List");
                        Dictionary<string, Dictionary<string, object>> getAddressBook = AddressBookOperaton.Return_AddressBook();
                        foreach (var books in getAddressBook )
                        {
                            Console.WriteLine(books.Key);
                        }
                        AdderssBookname = Console.ReadLine();
                        while (!getAddressBook.ContainsKey(AdderssBookname))
                        {
                            Console.WriteLine("No such AddressBook found. Try Again.");
                            AdderssBookname = Console.ReadLine();
                     
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


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using uc4_DeleteData;

namespace AddressBooks
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                    Addressbook.GetCustomer();
                    Addressbook.ListingPeople();
                    break;
                case "2":
                    Addressbook.GetCustomer();
                    Addressbook.Modify();
                   Addressbook.ListingPeople();
                    break;
                case "3":
                   Addressbook.GetCustomer();
                   Addressbook.ListingPeople();
                    break;
                case "4":
                    Addressbook.GetCustomer();
                   Addressbook.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }


        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;

namespace adressBook
{
    class Program
    {


        /// <summary>
        /// The list
        /// </summary>
        static List<contactBook> list = new List<contactBook>();

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book program");

            int n;
            Console.WriteLine("Enter the number of contacts : ");
            n = Convert.ToInt32(Console.ReadLine());
            contactBook[] contacts = new contactBook[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the first name");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter the last name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter the city name");
                string city = Console.ReadLine();

                Console.WriteLine("Enter the state name");
                string state = Console.ReadLine();

                Console.WriteLine("Enter the zip code");
                int zip = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the phone number");
                string phoneNumber = Console.ReadLine();

                Console.WriteLine("Enter the email id");
                string emailId = Console.ReadLine();


                contacts[i] = new contactBook(firstName, lastName, city, state, zip, phoneNumber, emailId);

            
                list.Add(contacts[i]);
             
            }

            displayContact();
            editContact("venkey");
            displayContact();
            deleteContact("venkey");
            displayContact();
           
        }

        /// <summary>
        /// Edits the contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        public static void editContact(string firstName)
        {
            foreach(var temp in list)
            {
                if(temp.getFirstName().Equals(firstName))
                {
                    Console.WriteLine("Enter the new Number for : "+firstName);
                    // phoneBook[firstName]= Console.ReadLine();
                    temp.setPhoneNumber(Console.ReadLine());
                    break;
                }
            }
        }

        /// <summary>
        /// Deletes the contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        public static void deleteContact(string firstName)
        {
            foreach (var temp in list)
            {
                if (temp.getFirstName().Equals(firstName))
                {
                    list.Remove(temp);
                    break;
                }
            }
        }

        /// <summary>
        /// Displays the contact.
        /// </summary>
        public static void displayContact()
        {
            foreach (var temp in list)
            {
                Console.WriteLine("Name : " + temp.getFirstName() + "  Contact No : " + temp.getPhoneNumber());
            }
        }
    }
}

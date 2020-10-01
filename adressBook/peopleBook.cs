using System;
using System.Collections.Generic;
using System.Text;

namespace adressBook
{

   
    class peopleBook
    {

        /// <summary>
        /// The list
        /// </summary>
        static List<contactBook> list = new List<contactBook>(); 
        /// <summary>
        /// Gets the input.
        /// </summary>
        public  void getInput()
        {
            contactBook contact;
            // int i = 0;
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
            contact = new contactBook(firstName, lastName, city, state, zip, phoneNumber, emailId);
            list.Add(contact);


        }

        /// <summary>
        /// Edits the contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        public  void editContact()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("There are no contacts to Edit");
            }
            else
            {
                Console.WriteLine("Enter the first name to edit ");
                string firstName = Console.ReadLine();
                foreach (var temp in list)
                {
                    if (temp.getFirstName().Equals(firstName))
                    {
                        Console.WriteLine("Enter the new Number for : " + firstName);
                        // phoneBook[firstName]= Console.ReadLine();
                        temp.setPhoneNumber(Console.ReadLine());
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Deletes the contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        public  void deleteContact()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("There are no contacts to Delete");
            }
            else
            {
                Console.WriteLine("Enter the first name to delete ");
                string firstName = Console.ReadLine();

                foreach (var temp in list)
                {
                    if (temp.getFirstName().Equals(firstName))
                    {
                        list.Remove(temp);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Displays the contact.
        /// </summary>
        public  void displayContact()
        {
            foreach (var temp in list)
            {
                Console.WriteLine("Name : " + temp.getFirstName() + "  Contact No : " + temp.getPhoneNumber());
            }
        }
    }
}

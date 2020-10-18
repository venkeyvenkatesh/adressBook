using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;

namespace adressBook
{
    class Program
    {
        
        static Dictionary<string, peopleBook> dict = new Dictionary<string, peopleBook>();


        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args) 

        {
            //variables
            int n=0;
            int option = 0;
            Console.WriteLine("Welcome to Address Book program");

            Console.WriteLine("How many people's contacts you want to add");
            try
            {
                 n = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("You have entered wrong input");
            }

            
         
            peopleBook[] obj = new peopleBook[n];
            for (int i = 0; i < n; i++)
            {
                string name;
                Console.WriteLine("Enter your name : ");
                name = Console.ReadLine();
                while (!peopleBook.validateString(name))
                {
                    Console.WriteLine("Please Enter the proper name ");
                     name = Console.ReadLine();
                }
                obj[i] = new peopleBook();
                dict.Add(name, obj[i]);
                
                do
                {
                  
                    Console.WriteLine("\n");
                    Console.WriteLine("Choose Your Option");
                    Console.WriteLine("1.Add new contact\n2.Edit the contact\n3.Delete the contact\n4.Display all contact\n5.Exit");
                    try
                    {

                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("You have entered wrong input");
                    }

                    if (option == 1)
                    {
                        obj[i].addContact();

                    }
                    else if (option == 2)
                    {

                        obj[i].editContact();
                    }
                    else if (option == 3)
                    {

                        obj[i].deleteContact();
                    }
                    else if (option == 4)
                    {
                        obj[i].displayContact();
                    }
                    else
                    {
                        break;
                    }

                    Console.WriteLine("\n");
                } while (option <= 5);

                displayPersonContacts(name);
            }



        }

        /// <summary>
        /// Displays the person contacts.
        /// </summary>
        /// <param name="name">The name.</param>
        public static void displayPersonContacts(string name)
        {
            foreach (KeyValuePair<string,peopleBook> kvp in dict)
            {
                if (kvp.Key.Equals(name))
                {
                    Console.WriteLine("Hey " + name );
                    kvp.Value.displayContact();
                }
            }
        }
    }
}

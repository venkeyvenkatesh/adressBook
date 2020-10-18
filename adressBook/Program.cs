using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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

            int option = 0;
            Console.WriteLine("Welcome to Address Book program");
            int choose = 0;



            do
            {
                Console.WriteLine("1.Add an Adress Book\n2.Display Address Book\n3.Search by State\n4.Search by City \n5.Exit");
                choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 1)
                {
                    peopleBook obj = new peopleBook();

                    string name;
                    Console.WriteLine("Enter your name : ");
                    name = Console.ReadLine();
                    while (!peopleBook.validateString(name))
                    {
                        Console.WriteLine("Please Enter the proper name ");
                        name = Console.ReadLine();
                    }
                    obj = new peopleBook();
                    dict.Add(name, obj);

                    do
                    {

                        Console.WriteLine("\n");
                        Console.WriteLine("Choose Your Option");
                        Console.WriteLine("1.Add new contact\n2.Edit the contact\n3.Delete the contact\n4.Display all contact\n5.Exit from your Address Book");
                        try
                        {

                            option = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("You have entered wrong input");
                        }

                        if (option == 1)
                        {
                            obj.addContact();

                        }
                        else if (option == 2)
                        {

                            obj.editContact();
                        }
                        else if (option == 3)
                        {

                            obj.deleteContact();
                        }
                        else if (option == 4)
                        {
                            obj.displayContact();
                        }
                        else
                        {
                            break;
                        }

                        Console.WriteLine("\n");
                    } while (option <= 5);
                }
                else if (choose == 2)
                {
                    displayPersonContacts();
                }
                else if (choose == 3)
                {

                    searchByState();
                }

                else if (choose == 4)
                {
                    searchByCity();
                }

                else
                {
                    break;
                }
            } while (choose <= 6);


        }





        /// <summary>
        /// Displays the person contacts.
        /// </summary>
        /// <param name="name">The name.</param>
        public static void displayPersonContacts()
        {
            int check = 0;
            if (dict.Count == 0)
            {
                Console.WriteLine("\nNo Address Books to Display\n");
                check = 1;
            }
            else
            {
                Console.WriteLine("Enter your name to display your Address Book");
                string name = Console.ReadLine();
                foreach (KeyValuePair<string, peopleBook> kvp in dict)
                {
                    if (kvp.Key.Equals(name))
                    {
                        Console.WriteLine("Hey " + name);
                        kvp.Value.displayContact();
                        check = 1;

                    }
                }
            }
            if (check == 0)
            {
                Console.WriteLine("\nNo Adress Book saved for the given name\n");
            }
        }


        /// <summary>
        /// Search for the given contact based on state
        /// </summary>

        public static void searchByState()
        {
            if (peopleBook.statewiseContact.Count == 0)
            {
                Console.WriteLine("\nNo Address Book have been added to search\n");
            }
            else
            {

                Console.WriteLine("Enter the state name to search ");
                string state = Console.ReadLine();
                int count = 0;
                foreach (var element in peopleBook.statewiseContact)
                {
                    if (element.Value.Equals(state))
                    {
                        Console.WriteLine("\n" + element.Key);
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("\nNo contacts saved for the given State Name\n");
                }
                else
                {
                    Console.WriteLine("No of contacts in the " + state + " state is " + count);
                    //  countBasedOnState.Add(state, count);

                }
            }
        }


        /// <summary>
        /// Search for the given contact based on City
        /// </summary>
        public static void searchByCity()
        {
            if (peopleBook.citywiseContact.Count == 0)
            {
                Console.WriteLine("\nNo Address Book have been added to search\n");
            }
            else
            {

                Console.WriteLine("Enter the city name to search ");
                string city = Console.ReadLine();
                int count = 0;
                foreach (var element in peopleBook.citywiseContact)
                {
                    if (element.Value.Equals(city))
                    {
                        Console.WriteLine("\n" + element.Key);
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("\nNo contacts saved for the given city Name\n");
                }
                else
                {
                    Console.WriteLine("No of contacts in the " + city + " city is " + count);
                }
            }
        }




    }
}

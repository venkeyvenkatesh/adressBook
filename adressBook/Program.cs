using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;

namespace adressBook
{
    class Program
    {

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book program");

            int option;
            peopleBook obj = new peopleBook();

            do
            {
                Console.WriteLine("Choose Your Option");
                Console.WriteLine("1.Add new contact\n2.Edit the contact\n3.Delete the contact\n4.Display all contact\n5.Exit");

                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    obj.getInput();

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
                    Environment.Exit(1);
                }
            } while (option <= 5);

        }

       
    }
}

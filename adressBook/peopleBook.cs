using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace adressBook
{


  public class peopleBook
    {

        /// <summary>
        /// The list
        /// </summary>
       public List<contactBook> list = new List<contactBook>();
       public  static Dictionary<string,string> statewiseContact= new Dictionary<string,string>();
        public static Dictionary<string, string> citywiseContact = new Dictionary<string, string>();

      
        /// <summary>
        /// Adds the contact.
        /// </summary>
        public void addContact()
        {
            contactBook contact;
            // int i = 0;
            Console.WriteLine("Enter the first name");
            string firstName = Console.ReadLine();
            while (!validateString(firstName))
            {
                Console.WriteLine("Please Enter the proper first name");
                firstName = Console.ReadLine();
            }
            if (!Equals(firstName))
            {
                Console.WriteLine("Enter the last name");
                string lastName = Console.ReadLine();
                while (!validateString(lastName))
                {
                    Console.WriteLine("Please Enter the proper Last name");
                    lastName = Console.ReadLine();
                }
                Console.WriteLine("Enter the address");
                string address = Console.ReadLine();
                while (!validateString(address))
                {
                    Console.WriteLine("Enter the proper address");
                    address = Console.ReadLine();
                }
                Console.WriteLine("Enter the city name");
                string city = Console.ReadLine();
                while (!validateString(city))
                {
                    Console.WriteLine("Please Enter the proper city name");
                    city = Console.ReadLine();
                }
                Console.WriteLine("Enter the state name");
                string state = Console.ReadLine();
                while (!validateString(state))
                {
                    Console.WriteLine("Please Enter the proper state name");
                    state = Console.ReadLine();
                }
                Console.WriteLine("Enter the zip code");
                string zip = Console.ReadLine();
                while (!validateZip(zip))
                {
                    Console.WriteLine("Please Enter the proper zip code");
                    zip = Console.ReadLine();
                }


                Console.WriteLine("Enter the phone number");

                string phoneNumber = Console.ReadLine();
                while (!validatePhoneNumber(phoneNumber))
                {
                    Console.WriteLine("Please enter proper mobile number");
                    phoneNumber = Console.ReadLine();
                }

                Console.WriteLine("Enter the email id");
                string emailId = Console.ReadLine();
                while (!validateEmailId(emailId))
                {
                    Console.WriteLine("Please enter proper Email ID ");
                    emailId = Console.ReadLine();
                }




                contact = new contactBook(firstName, lastName, address, city, state, zip, phoneNumber, emailId);
                list.Add(contact);

                statewiseContact.Add(firstName, state);
                citywiseContact.Add(firstName, city);
            }
            else
            {
                Console.WriteLine("\nSorry!!!! There is a contact already saved for the given first Name");
            }


        }



        /// <summary>
        /// Validates the phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        /// <returns></returns>
        public bool validatePhoneNumber(string phoneNumber)
        {
            String reg = @"(^[+[1-9]{1,}[0-9\\-]{0,}[ ]{1}[1-9]{1}[0-9]{9}$)";
            Regex re = new Regex(reg);
            if (re.IsMatch(phoneNumber))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Validates the zip.
        /// </summary>
        /// <param name="zip">The zip.</param>
        /// <returns></returns>
        public bool validateZip(string zip)
        {


            String reg = @"(^[1-9]{1}[0-9]{5}$)";
            Regex re = new Regex(reg);
            if (re.IsMatch(zip))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Validates the string.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static bool validateString(string name)
        {
            String reg = @"(^[A-Za-z]{2,}$)";
            Regex re = new Regex(reg);
            if (re.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Validates the email identifier.
        /// </summary>
        /// <param name="emailId">The email identifier.</param>
        /// <returns></returns>
        public bool validateEmailId(string emailId)
        {

            String reg = "(^[a-zA-Z0-9]{1,}([+-_.][a-zA-Z0-9]{1,}){0,}@[a-zA-Z0-9]{1,}(\\.[a-zA-Z]{1,}){0,1}(\\.[a-zA-Z]{2,})$)";
            ;

            Regex re = new Regex(reg);
            if (re.IsMatch(emailId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Edits the contact.
        /// </summary>
        public void editContact()
        {
            int check = 0;
            int choice = 0;
            if (list.Count == 0)
            {
                Console.WriteLine("There are no contacts to Edit");
                check = 1;
            }
            else
            {
                Console.WriteLine("Enter the first name to edit ");
                string firstName = Console.ReadLine();
                while (!validateString(firstName))
                {
                    Console.WriteLine("Please Enter the proper First name");
                    firstName = Console.ReadLine();
                }
                foreach (var temp in list)
                {
                    if (temp.getFirstName().Equals(firstName))
                    {
                        Console.WriteLine("Select which field you want to edit");

                        Console.WriteLine("1.FirstName\n2.LastName\n3.Address\n4.City\n5.State\n6.Zip\n7.Phone Number\n8.Email Id");
                        try
                        {
                            choice = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Given Invalid input ");
                        }
                        if (choice == 1)
                        {
                            Console.WriteLine("Enter the new First Name");
                            firstName = Console.ReadLine();
                            while (!validateString(firstName))
                            {
                                Console.WriteLine("Please Enter the proper First name");
                                firstName = Console.ReadLine();
                            }
                            temp.setFirstName(firstName);
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("Enter the new Last Name");
                            string lastName = Console.ReadLine();
                            while (!validateString(lastName))
                            {
                                Console.WriteLine("Please Enter the proper Last name");
                                lastName = Console.ReadLine();
                            }
                            temp.setLastName(lastName);
                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine("Enter the new Address");
                            string address = Console.ReadLine();
                            while (!validateString(address))
                            {
                                Console.WriteLine("Please Enter the proper First name");
                                address = Console.ReadLine();
                            }
                            temp.setAddress(address);
                        }
                        else if (choice == 4)
                        {
                            Console.WriteLine("Enter the new City name ");
                            string city = Console.ReadLine();
                            while (!validateString(city))
                            {
                                Console.WriteLine("Please Enter the proper First name");
                                city = Console.ReadLine();
                            }
                            temp.setCity(city);
                        }
                        else if (choice == 5)
                        {
                            Console.WriteLine("Enter the new state name ");
                            string state = Console.ReadLine();
                            while (!validateString(state))
                            {
                                Console.WriteLine("Please Enter the proper First name");
                                state = Console.ReadLine();
                            }
                            temp.setState(state);
                        }
                        else if (choice == 6)
                        {
                            Console.WriteLine("Enter the new Zip ");
                            string zip = Console.ReadLine();
                            while (!validateZip(zip))
                            {
                                Console.WriteLine("Enter the proper zip code");
                                zip = Console.ReadLine();
                            }
                            temp.setZip(zip);
                        }
                        else if (choice == 7)
                        {
                            Console.WriteLine("Enter the new phone number ");
                            string phoneNumber = Console.ReadLine();
                            while (!validatePhoneNumber(phoneNumber))
                            {
                                Console.WriteLine("Please enter proper mobile number");
                                phoneNumber = Console.ReadLine();
                            }
                            temp.setPhoneNumber(phoneNumber);

                        }
                        else
                        {
                            Console.WriteLine("Enter the new Email Id");
                            string emailId = Console.ReadLine();
                            while (!validateEmailId(emailId))
                            {
                                Console.WriteLine("Please enter proper Email Id");
                                emailId = Console.ReadLine();
                            }
                            temp.setEmailId(emailId);
                        }

                        check = 1;
                        Console.WriteLine("Edited Successfully");

                        break;
                    }
                }
                if (check == 0)
                {
                    Console.WriteLine("No contact saved for the given name");
                }
            }
        }

        /// <summary>
        /// Deletes the contact.
        /// </summary>
        public void deleteContact()
        {
            int check = 0;
            if (list.Count == 0)
            {
                Console.WriteLine("There are no contacts to Delete");
                check = 1;
            }
            else
            {
                Console.WriteLine("Enter the first name to delete ");
                string firstName = Console.ReadLine();
                while (!validateString(firstName))
                {
                    Console.WriteLine("Please Enter the proper First name");
                    firstName = Console.ReadLine();
                }

                foreach (var temp in list)
                {
                    if (temp.getFirstName().Equals(firstName))
                    {
                        list.Remove(temp);
                        check = 1;
                        Console.WriteLine("Deleted Successfully");

                        break;
                    }
                }
                if (check == 0)
                {
                    Console.WriteLine("No Contact Saved for given name");
                }
            }
        }

        /// <summary>
        /// Displays the contact.
        /// </summary>
        public void displayContact()
        {

            if (list.Count == 0)
            {
                Console.WriteLine("\nNo contacts to Display\n");
             
            }

            else
            {
                SortBasedOnName();
                Console.WriteLine("FirstName\tLastName\taddress\tCity\tState\tZip\tPhoneNumber\tEmail-Id");
                foreach (var temp in list)
                {
                   

                    Console.WriteLine(temp.getFirstName() + "\t\t" + temp.getLastName() + "\t\t" + temp.getAddress() + "\t" + temp.getCity() + "\t" + temp.getState() + "\t" + temp.getZip() + "\t" + temp.getPhoneNumber() + "\t" + temp.getEmailId());
                }
            }
        }


        /// <summary>
        /// checks the euality with the specified first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns></returns>
      public bool Equals(string firstName)
        {
            foreach (var contact in list)
            {
                if (contact.getFirstName()==firstName)
                {
                    return true;
                }
            }
            return false;


        }

        public void SortBasedOnName()
        {
            list = list.OrderBy(o => o.getFirstName()).ToList();

        }


    }
}

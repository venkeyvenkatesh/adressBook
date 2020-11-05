using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Net.Mail;
using System.Globalization;
using CsvHelper;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

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

        
        public void writeIntoCSV()
        {
            string exportPath = @"C:\Users\Administrator\source\repos\adressBook\adressBook\contacts.csv";
           
            using (StreamWriter sw = new StreamWriter(exportPath))
            using (CsvWriter writer = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                writer.WriteRecords(list);
            }
        }

        public void DisplayCsvFile()
        {
            String importPath = @"C:\Users\Administrator\source\repos\adressBook\adressBook\contacts.csv";

            using(StreamReader sr=new StreamReader(importPath))
            using(CsvReader reader=new CsvReader(sr,CultureInfo.InvariantCulture))
            {
                List<contactBook> records = reader.GetRecords<contactBook>().ToList();
              
                foreach(var record in records)
                {
                    
                    Console.WriteLine( record.FirstName+"\t" + record.LastName + "\t" + record.Address + "\t" + record.City + "\t" + record.State + "\t" + record.PhoneNumber + "\t" + record.EmailId);
                }
            }
        }

        public void writeIntoJSON()
        {
            String importPath = @"C:\Users\Administrator\source\repos\adressBook\adressBook\contacts.csv";
            string exportPath = @"C:\Users\Administrator\source\repos\adressBook\adressBook\contacts.json";
            using (StreamReader sr = new StreamReader(importPath))
            using (CsvReader reader = new CsvReader(sr, CultureInfo.InvariantCulture))
            {
                var records = reader.GetRecords<contactBook>().ToList();

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportPath)) 
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }


        }

        public void DisplayJsonFile()
        {
            string exportPath = @"C:\Users\Administrator\source\repos\adressBook\adressBook\contacts.json";

            IList<contactBook> contactBooks = JsonConvert.DeserializeObject<IList<contactBook>>(File.ReadAllText(exportPath));

            foreach(var contact in contactBooks)
            {
               
                Console.WriteLine(contact.FirstName + "\t" + contact.LastName + "\t" + contact.Address + "\t" + contact.City + "\t" + contact.State + "\t" + contact.PhoneNumber + "\t" + contact.EmailId);

            }

        }
        /// <summary>
        /// Adds the contact.
        /// </summary>
        public void addContact()
        {
            contactBook contact;
           
            Console.WriteLine("Enter the first name");
            string FirstName = Console.ReadLine();
            while (!validateString(FirstName))
            {
                Console.WriteLine("Please Enter the proper first name");
                FirstName = Console.ReadLine();
            }
            if (!Equals(FirstName))
            {

                Console.WriteLine("Enter the last name");
                string LastName = Console.ReadLine();
                while (!validateString(LastName))
                {
                    Console.WriteLine("Please Enter the proper Last name");
                    LastName = Console.ReadLine();
                }
                Console.WriteLine("Enter the address");
                string Address = Console.ReadLine();
                while (!validateString(Address))
                {
                    Console.WriteLine("Enter the proper address");
                    Address = Console.ReadLine();
                }
                Console.WriteLine("Enter the city name");
                string City = Console.ReadLine();
                while (!validateString(City))
                {
                    Console.WriteLine("Please Enter the proper city name");
                    City = Console.ReadLine();
                }
                Console.WriteLine("Enter the state name");
                string State = Console.ReadLine();
                while (!validateString(State))
                {
                    Console.WriteLine("Please Enter the proper state name");
                    State = Console.ReadLine();
                }
                Console.WriteLine("Enter the zip code");
                string Zip = Console.ReadLine();
                while (!validateZip(Zip))
                {
                    Console.WriteLine("Please Enter the proper zip code");
                    Zip = Console.ReadLine();
                }


                Console.WriteLine("Enter the phone number");

                string PhoneNumber = Console.ReadLine();
                while (!validatePhoneNumber(PhoneNumber))
                {
                    Console.WriteLine("Please enter proper mobile number");
                    PhoneNumber = Console.ReadLine();
                }

                Console.WriteLine("Enter the email id");
                string EmailId = Console.ReadLine();
                while (!validateEmailId(EmailId))
                {
                    Console.WriteLine("Please enter proper Email ID ");
                    EmailId = Console.ReadLine();
                }





                string path = "E:\\ContactFIle\\contacts.txt";


                contact = new contactBook(FirstName, LastName, Address, City, State, Zip, PhoneNumber, EmailId);
                list.Add(contact);
                string text=contact.FirstName+"\t"+contact.LastName + "\t"+contact.Address + "\t" + contact.City+ "\t" + contact.State + "\t" + contact.Zip+ "\t" + contact.PhoneNumber + "\t" + contact.EmailId+"\n";
                File.AppendAllText(path,text);

                statewiseContact.Add(FirstName, State);
                citywiseContact.Add(FirstName, City);


               

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
            string oldFirstName;
         
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
                    if (temp.FirstName.Equals(firstName))
                    {
                        oldFirstName = temp.FirstName;
                        Console.WriteLine("Select which field you want to edit");

                        Console.WriteLine("1.FirstName\n2.LastName\n3.Address\n4.City\n5.State\n6.Zip\n7.Phone Number\n8.Email Id");
                        try
                        {
                            choice = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
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
                            temp.FirstName=firstName;
                      
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
                            temp.LastName=lastName;
                       
                        }
                        else if (choice == 3)
                        {
                       
                            Console.WriteLine("Enter the new Address");
                            string address = Console.ReadLine();
                            while (!validateString(address))
                            {
                                Console.WriteLine("Please Enter the proper Address");
                                address = Console.ReadLine();
                            }
                            temp.Address = address;
                        
                        }
                        else if (choice == 4)
                        {
                        
                            Console.WriteLine("Enter the new City name ");
                            string city = Console.ReadLine();
                            while (!validateString(city))
                            {
                                Console.WriteLine("Please Enter the proper City name");
                                city = Console.ReadLine();
                            }
                            temp.City=city;
                       
                        }
                        else if (choice == 5)
                        {
                         
                            Console.WriteLine("Enter the new state name ");
                            string state = Console.ReadLine();
                            while (!validateString(state))
                            {
                                Console.WriteLine("Please Enter the proper state name");
                                state = Console.ReadLine();
                            }
                            temp.State=state;
                    
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
                            temp.Zip=zip;
                        
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
                            temp.PhoneNumber=phoneNumber;
                      

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
                            temp.EmailId=emailId;
                        
                        }

                        check = 1;
                        Console.WriteLine("Edited Successfully");
                        string path = "E:\\ContactFIle\\contacts.txt";
                       
                        string[] lines = File.ReadAllLines(path);
                        List<string> fileList = lines.ToList();
                        int count = 0;
                        foreach(var line in lines)
                        {
                            count++;
                            if(line.Contains(oldFirstName))
                            {
                                string text = temp.FirstName + "\t" + temp.LastName + "\t" + temp.Address + "\t" + temp.City + "\t" + temp.State + "\t" + temp.Zip+ "\t" + temp.PhoneNumber + "\t" + temp.EmailId + "\n";

                                fileList[count-1] = text;

                                break;
                            }
                        }
                        File.WriteAllLines(path, fileList.ToArray());
                       

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

            string path = "E:\\ContactFIle\\contacts.txt";
            string[] lines = File.ReadAllLines(path);
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
                    if (temp.FirstName.Equals(firstName))
                    {
                        list.Remove(temp);
                        check = 1;
                        int count = 0;
                        Console.WriteLine("Deleted Successfully");
                        foreach(var line in lines)
                        {
                            count++;
                            if(line.Contains(temp.FirstName))
                                {
                              
                                List<string> listFile = lines.ToList();
                                listFile.RemoveAt(count-1);
                                File.WriteAllLines(path, listFile.ToArray());
                                break;
                            }
                        }
                     
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
                //   SortBasedOnCity();
                //   SortBasedOnState();
                //   SortBasedOnZip();
                Console.WriteLine("FirstName\tLastName\taddress\tCity\tState\tZip\tPhoneNumber\tEmail-Id");
                foreach (var temp in list)
                {


                    Console.WriteLine(temp.FirstName + "\t\t" + temp.LastName + "\t\t" + temp.Address + "\t" + temp.City + "\t" + temp.State + "\t" + temp.Zip + "\t" + temp.PhoneNumber + "\t" + temp.EmailId);

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
                if (contact.FirstName==firstName)
                {
                    return true;
                }
            }
            return false;


        }
        
        public void SortBasedOnName()
        {
            list = list.OrderBy(o => o.FirstName).ToList();

        }
        public void SortBasedOnCity()
        {
            list = list.OrderBy(o => o.City).ToList();

        }
        public void SortBasedOnState()
        {
            list = list.OrderBy(o => o.State).ToList();

        }
        public void SortBasedOnZip()
        {
            list = list.OrderBy(o => o.Zip).ToList();

        }

      
    }
}

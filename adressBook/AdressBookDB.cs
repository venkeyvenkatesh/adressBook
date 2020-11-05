using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace adressBook
{
    public class AdressBookDB
    {
       
       // public static string connectionString= @" Data Source = (LocalDb)\VenkeyServer;Initial Catalog = AddressBookSystem; Integrated Security = True";
      // public static  SqlConnection connection = new SqlConnection(connectionString);


        public List<contactBook> getAllContacts()
        {
            string connectionString = @" Data Source = (LocalDb)\VenkeyServer;Initial Catalog = AddressBookSystem; Integrated Security = True";
               SqlConnection connection = new SqlConnection(connectionString);

            List<contactBook> list = new List<contactBook>();
                try
                {
                 
                    using (connection)
                    {
                        string query = @"select * from AddressBook";
                        SqlCommand cnd = new SqlCommand(query, connection);
                        connection.Open();

                        SqlDataReader dr = cnd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                            contactBook contact = new contactBook();
                            contact.FirstName= dr.GetString(0);
                                contact.LastName = dr.GetString(1);
                                contact.Address = dr.GetString(2);
                                contact.State = dr.GetString(3);
                                contact.City = dr.GetString(4);
                             contact.Zip = Convert.ToString(dr.GetInt32(5));
                           
                                contact.PhoneNumber = dr.GetString(6);
                                contact.EmailId = dr.GetString(7);

                                Console.WriteLine(contact.FirstName + "   " + contact.LastName + "   " + contact.Address + "   " + contact.State + "   " + contact.City + "   "+contact.Zip + "   " + contact.PhoneNumber + "   " + contact.EmailId);
                             
                                Console.WriteLine("");

                            list.Add(contact);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No DAta found");
                        }
                        dr.Close();
                        connection.Close();
                    return list;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
                    
        }



    }


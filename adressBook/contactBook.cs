using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace adressBook
{
   public class contactBook
    {
       
        //variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="contactBook"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="emailId">The email identifier.</param>
        public contactBook(string firstName ,string lastName ,string address,string city ,string state, string zip, string phoneNumber ,string emailId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.PhoneNumber = phoneNumber;
            this.EmailId = emailId;
        }
        public contactBook()
        {

        }

        
      

       


    }
}

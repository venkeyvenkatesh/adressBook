using System;
using System.Collections.Generic;
using System.Text;

namespace adressBook
{
    class contactBook
    {
        //variables
        private string firstName;
        private string lastName;
        private string city;
        private string state;
        private int zip;
        private string phoneNumber;
        private string emailId;

        /// <summary>
        /// Initializes a new instance of the <see cref="contactBook"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="emailId">The email identifier.</param>
        public contactBook(string firstName ,string lastName ,string city ,string state, int zip, string phoneNumber ,string emailId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.emailId = emailId;
        }


        /// <summary>
        /// Displays the contact.
        /// </summary>
        public void displayContact()
        {
            Console.WriteLine("Name : " + this.firstName + "  Contact No : " + this.phoneNumber);
        }
       // Dictionary<string, string> dictionary = new Dictionary<string, string>();



    }
}

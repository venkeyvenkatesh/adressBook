using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
        /// Gets the first name.
        /// </summary>
        /// <returns></returns>
        public string getFirstName()
        {
            return this.firstName;

        }

        /// <summary>
        /// Gets the phone number.
        /// </summary>
        /// <returns></returns>
        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }

        /// <summary>
        /// Sets the phone number.
        /// </summary>
        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        
      



    }
}

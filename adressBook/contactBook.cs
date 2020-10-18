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
        private string address;
        private string city;
        private string state;
        private string zip;
        private string phoneNumber;
        private string emailId;

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
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
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
        /// Gets the last name.
        /// </summary>
        /// <returns></returns>
        public string getLastName()
        {
            return this.lastName;
        }

        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <returns></returns>
        public string getAddress()
        {
            return this.address;
        }

        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <returns></returns>
        public string getCity()
        {
            return this.city;
        }

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <returns></returns>
        public string getState()
        {
            return this.state;
        }

        /// <summary>
        /// Gets the zip.
        /// </summary>
        /// <returns></returns>
        public string getZip()
        {
            return this.zip;
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
        /// Gets the email identifier.
        /// </summary>
        /// <returns></returns>
        public string getEmailId()
        {
            return this.emailId;
        }


        /// <summary>
        /// Sets the first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        public void setFirstName(string firstName)
        {
            this.firstName= firstName;
        }

        /// <summary>
        /// Sets the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        /// <summary>
        /// Sets the address.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        public void setAddress(string address)
        {
            this.address = address;
        }
        /// <summary>
        /// Sets the city.
        /// </summary>
        /// <param name="city">The city.</param>
        public void setCity(string city)
        {
            this.city = city;
        }

        /// <summary>
        /// Sets the state.
        /// </summary>
        /// <param name="state">The state.</param>
        public void setState(string state)
        {
            this.state = state;
        }

        /// <summary>
        /// Sets the zip.
        /// </summary>
        /// <param name="zip">The zip.</param>
        public void setZip(string zip)
        {
            this.zip =zip;
        }

        /// <summary>
        /// Sets the phone number.
        /// </summary>
        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }


        /// <summary>
        /// Sets the email identifier.
        /// </summary>
        /// <param name="emailId">The email identifier.</param>
        public void setEmailId(string emailId)
        {
            this.emailId=emailId;
        }


       


    }
}

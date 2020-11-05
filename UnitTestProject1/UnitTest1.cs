using adressBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReadingContactsFromDataBase()

        {

            AdressBookDB db = new AdressBookDB();
            List<contactBook> dbList=db.getAllContacts();

            int expected = 5;
            int actual = dbList.Count;
            Assert.AreEqual(expected, actual);

            string expectedName = dbList[0].FirstName;
            string actualName = "kiran";

            Assert.AreEqual(expectedName, actualName);
        }
    }
}

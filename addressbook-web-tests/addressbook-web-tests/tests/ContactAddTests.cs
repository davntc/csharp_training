using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using addressbook_web_tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactAddTests : AuthTestBase
    {
        
        [Test]
        public void ContactCreationTest()
        {
           
            
            ContactData contact = new ContactData("Ivan","Ivanov");
            //contact.Lastname = "Ivanov";

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.ContAdd(contact);

            List<ContactData> newContacts = app.Contacts.GetContactList();

            Assert.AreEqual(oldContacts.Count + 1, newContacts.Count);

        }
                                 
                              
    }
}


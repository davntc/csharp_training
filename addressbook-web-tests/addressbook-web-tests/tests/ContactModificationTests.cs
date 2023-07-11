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
    public class ContactModificationTests : AuthTestBase
    {

        [Test]
        public void ContactModificationTest()
        {
            if (app.Contacts.CheckCanSelectContact(1))
            {
                app.Contacts.SelectContact(1);
            }
            else
            {
                app.Contacts.ContAdd(new ContactData(""));
            }

            ContactData newContact = new ContactData("Petr", "Petrov");

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.ContModify(newContact);

            app.Contacts.GoToHomepage();

            List<ContactData> newContacts = app.Contacts.GetContactList();

            Assert.AreEqual(oldContacts.Count, newContacts.Count);

        }


    }
}
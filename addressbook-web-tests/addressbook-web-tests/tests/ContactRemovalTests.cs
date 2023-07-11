using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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
    public class ContactRemovalTests : AuthTestBase
    {

        [Test]
        public void ContactRemovalTest()
        {
            if (app.Contacts.CheckCanSelectContact(1))
            {
                app.Contacts.SelectContact(1);
            }
            else
            {
                app.Contacts.ContAdd(new ContactData(""));
            }

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Remove(1,new ContactData(""));

            List<ContactData> newContacts = app.Contacts.GetContactList();

            oldContacts.RemoveAt(0);

            Assert.AreEqual(oldContacts.Count, newContacts.Count - 1);

        }


    }
}

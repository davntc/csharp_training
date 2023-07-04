﻿using System;
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


            ContactData newContact = new ContactData("Petr");
            newContact.Lastname = "Petrov";

            app.Contacts.ContactCreated(1);
            app.Contacts.ContModify(newContact);


        }


    }
}
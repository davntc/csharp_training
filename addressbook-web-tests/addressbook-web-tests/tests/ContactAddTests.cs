using System;
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
    public class ContactAddTests : TestBase
    {
        
        [Test]
        public void ContactCreationTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.GoToAddingNewContact();
            ContactData contact = new ContactData("Ivan");
            contact.Lastname = "Ivanov";
            app.Contacts.FillContactFormm(contact);
            app.Contacts.AcceptContactInfo();
            app.Contacts.GoToHomepage();

        }
                                 
                              
    }
}


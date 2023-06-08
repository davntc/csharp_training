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
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToAddingNewContact();
            ContactData contact = new ContactData("Ivan");
            contact.Lastname = "Ivanov";
            FillContactFormm(contact);
            AcceptContactInfo();
            GoToHomepage();

        }
                                 
                              
    }
}


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
    public class ContactAddTests : AuthTestBase
    {
        
        [Test]
        public void ContactCreationTest()
        {
           
            
            ContactData contact = new ContactData("Ivan");
            contact.Lastname = "Ivanov";

            app.Contacts.ContAdd(contact);
            

        }
                                 
                              
    }
}


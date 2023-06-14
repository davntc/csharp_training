using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using addressbook_web_tests;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {

        public ContactHelper(ApplicationManager manager) : base(manager)
        {

        }
        public ContactHelper ContAdd(ContactData contact) 
        {
            GoToAddingNewContact();
            FillContactFormm(contact);
            AcceptContactInfo();
            GoToHomepage();
            return this;
        }

        public ContactHelper GoToAddingNewContact()
            {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
            }
        public ContactHelper FillContactFormm(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            return this;
        }
        public ContactHelper AcceptContactInfo()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public ContactHelper GoToHomepage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }
    }
}

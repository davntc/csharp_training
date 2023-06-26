using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using addressbook_web_tests;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {

        public ContactHelper(ApplicationManager manager) : base(manager)
        {

        }

        public ContactHelper ContModify(ContactData newContact)
        {
            SelectContact();
            InitContactModification();
            FillContactFormm(newContact);
            SubmitGroupModification();
            return this;

        }

        public ContactHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;

        }

        public ContactHelper InitContactModification()
        {
            driver.FindElement(By.XPath("//table[@id='maintable']/tbody/tr[5]/td[8]/a/img")).Click();
            driver.Navigate().GoToUrl("http://localhost/addressbook/edit.php?id=5");
            return this;
        }

        public ContactHelper SelectContact()
        {
            driver.FindElement(By.Id("5")).Click();
            return this;
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

        public ContactHelper Remove(int v)
        {
            SelectContact();
            RemoveContact(v, true);
            return this;
        }

        public ContactHelper RemoveContact(int v, bool acceptNextAlert)
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            // Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        private string CloseAlertAndGetItsText()
        {
            throw new NotImplementedException();
        }
    }
}

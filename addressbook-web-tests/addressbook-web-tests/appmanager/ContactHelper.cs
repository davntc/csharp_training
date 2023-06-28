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
using System.Reflection;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {

        public ContactHelper(ApplicationManager manager) : base(manager)
        {

        }

        public ContactHelper ContModify(ContactData newContact)
        {
            SelectContact(1);
            InitContactModification();
            FillContactFormm(newContact);
            SubmitContactModification();
            return this;

        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;

        }

        public ContactHelper InitContactModification()
        {
            //driver.FindElement(By.XPath("//table[@id='maintable']/tbody/tr[5]/td[8]/a/img")).Click();
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            driver.Navigate().GoToUrl("http://localhost/addressbook/edit.php?id=1");
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            // driver.FindElement(By.Id("1")).Click();
            //driver.FindElement((By.XPath("//input[@value='Login']"))
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
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
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("lastname"), contact.Lastname);
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
            SelectContact(1);
            RemoveContact(v, true);
            return this;
        }

        public ContactHelper RemoveContact(int v, bool acceptNextAlert)
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        private string CloseAlertAndGetItsText()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
             
         [Test]
        public void GroupCreationTest()
        {
            
            GroupData group = new GroupData("test");
            group.Header = "test1";
            group.Footer = "test2";

           
            app.Groups.Create(group);
               
        }
        [Test]
        public void EmptyGroupCreationTest()
        {
            
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

           
            app.Groups.Create(group);

        }


    }
}

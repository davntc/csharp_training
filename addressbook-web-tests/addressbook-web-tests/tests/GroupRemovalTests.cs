using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {

        [Test]
        public void GroupRemovalTest()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            if (app.Groups.CheckCanSelectGroup(1))
            {
                app.Groups.SelectGroup(1);
            }
            else
            {
                app.Groups.InitNewGroupCreation();
                app.Groups.FillGroupForm(new GroupData(""));
                app.Groups.SubmitGroupCreation();
            }

            app.Groups.Remove(0, new GroupData(""));

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(0);

            Assert.AreEqual(oldGroups.Count, newGroups.Count -1);
        }
    }
}

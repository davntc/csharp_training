using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
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
            GroupData newData = new GroupData("xxx");
            newData.Header = ("yyy");
            newData.Footer = null;

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Modify(0, newData);

            List<GroupData> newGroups = app.Groups.GetGroupList();

            Assert.AreEqual(oldGroups.Count, newGroups.Count);
        }
    }
}





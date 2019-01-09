using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupCreationTests: TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            List<GroupData> oldList = app.Groups.GetGroupsList();
            GroupData newGroup = new GroupData()
            {
                Name = "test"
            };

            app.Groups.Add(newGroup);
            List<GroupData> newList = app.Groups.GetGroupsList();
            oldList.Add(newGroup);
            oldList.Sort();
            newList.Sort();

            Assert.AreEqual(oldList, newList);
        }
    }
}

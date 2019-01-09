using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests: TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {
            List<GroupData> oldList = app.Groups.GetGroupsList();

            //oldList.Add(newGroup);
            //app.Groups.Remove(newGroup);


            List<GroupData> newList = app.Groups.GetGroupsList();

            oldList.Sort();
            newList.Sort();

            Assert.AreEqual(oldList, newList);
        }
    }
}

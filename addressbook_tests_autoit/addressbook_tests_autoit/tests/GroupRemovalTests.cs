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

            int groupCount = app.Groups.GetGroupsList().Count();
            while (groupCount < 2)
            {
                GroupData newGroup = new GroupData()
                {
                    Name = "test3"
                };
                app.Groups.Add(newGroup);
                groupCount++;
            }

            List<GroupData> oldList = app.Groups.GetGroupsList();

            app.Groups.Remove(0);


            List<GroupData> newList = app.Groups.GetGroupsList();
            oldList.RemoveAt(0);

            Assert.AreEqual(oldList.Count, newList.Count);

            oldList.Sort();
            newList.Sort();

            Assert.AreEqual(oldList, newList);
        }
    }
}

using NUnit.Framework;
using System;
using WebDriverUniversityTest.Pages;

namespace WebDriverUniversityTest.Tests
{
    [TestFixture]
    class ToDoListPageTests : BaseTestSuite
    {
        [Test]
        public void TestTaskName()
        {
            String taskItem = "Playing with fire";

            ToDoListPage toDoListPage = new HomePage(driver).ClickToDoList();
            toDoListPage.ClickAddItem().SetNewTask(taskItem);

            toDoListPage.GetToDoListItem(taskItem).SetItemStatus();
            toDoListPage.GetToDoListItem("Practice magic").SetItemStatus();
            toDoListPage.GetToDoListItem("Buy new robes").DeleteItem();

            Assert.AreEqual(1, toDoListPage.GetTotalCount() - toDoListPage.GetCompletedCount());
        }

    }
}

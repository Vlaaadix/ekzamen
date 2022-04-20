using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Library;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TaskList taskList = new TaskList("test");

            Assert.AreEqual("test", taskList.GetName());
        } 
        [TestMethod]
        public void TestMethod2()
        {
            List<Task> tasks = new List<Task>()
            {
                new Task() { Title = "title"},
                new Task()
            };

            TaskList taskList = new TaskList("test");
            taskList.AddTask(new Task() { Title = "title"});
            taskList.AddTask(new Task());

            Assert.AreEqual(tasks[0].Title, taskList.GetTasks()[0].Title);
        }
    }
}

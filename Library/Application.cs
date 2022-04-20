using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Application
    {
        public Application application;

        public List<TaskList> taskLists;

        /// <summary>
        /// Создает объект класса
        /// </summary>
        public Application()
        {
            TaskList TaskList = new TaskList("Входящие");
            taskLists = new List<TaskList>();
            taskLists.Add(TaskList);
        }

        /// <summary>
        /// Создает список с задачами и добавляет его в список со списками задач.
        /// </summary>
        /// <param name="name"></param>
        public void CreateTaskList(string name)
        {
            var TaskList = new TaskList(name);
            taskLists.Add(TaskList);
        }
    }
}

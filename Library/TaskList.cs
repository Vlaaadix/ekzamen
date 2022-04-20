using System.Collections.Generic;

namespace Library
{
    public class TaskList
    {
        public List<Task> tasks;
        public string name;

        /// <summary>
        /// Создает объект класса
        /// </summary>
        /// <param name="name"></param>
        public TaskList(string name)
        {
            tasks = new List<Task>();
            this.name = name;
        }

        /// <summary>
        /// Вернет имя списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Добавит задачу в список задач
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        /// <summary>
        /// Будет возвращен список всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }

        /// <summary>
        /// Удаляет задачу
        /// </summary>
        /// <param name="task"></param>
        public void Remove(Task task)
        {
            tasks.Remove(task);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    public class Task
    {
        static int maxId = 0;
        private int Id { get; set; }
        private string Name { get; set; }
        private bool IsDone { get; set; }
        private int Priority { get; set; }

        public Task()
        {
            Id = maxId++;
        }

        public Task(string name)
        {
            Id = maxId++;
            Name = name;
            IsDone = false;
            Priority = 0;
        }

        public Task(string name, int priority)
        {
            Id = maxId++;
            Name = name;
            IsDone = false;
            Priority = priority;
        }

        public void taskDone()
        {
            IsDone = true;
        }

        public string getName()
        {
            return Name;
        }

        public int getPriority()
        {
            return Priority;
        }

        public string ifDone()
        {
            if (IsDone == true)
            {
                return "done";
            }
            else
            {
                return "in progress";
            }
        }
    }
}

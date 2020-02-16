using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNPoints.Entities
{
    public class Student : User
    {
        public List<Task> TasksCompleted { get; set; }
        public List<Task> TasksTaken { get; set; }
        public double Points { get; set; }

        public Student()
        {
            TasksCompleted = new List<Task>();
            TasksTaken = new List<Task>();
        }
    }
}

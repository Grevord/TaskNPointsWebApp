using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNPoints.Entities
{
    public class Teatcher : User
    {
        public List<Task> TasksCreated { get; set; }

        public Teatcher()
        {
            TasksCreated = new List<Task>();
        }

    }

}

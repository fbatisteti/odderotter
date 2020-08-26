using System;

namespace OdderOtter.Shared.Classes
{
    public class ToDoThing
    {
        public DateTime timestamp { get; set; }
        public string task { get; set; }
        public Boolean done { get; set; }

        public ToDoThing(DateTime timestamp, string task)
        {
            this.timestamp = timestamp;
            this.task = task;
        }
    }
}
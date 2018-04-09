using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Unity3dLogs.Models
{
    public class UserTask
    {
        public User Owner { get; set; }
        public User Executor { get; set; }
        public Status TaskStatus { get; set; }   
        public string Header { get; set; }
        public string Description { get; set; }
        public string TaskOpenTime { get; set; }
        public string TaskCloseTime { get; set; }
        public string TaskResolveTime { get; set; }
        public bool IsClosed { get; set; }
        public bool WithOutExecutor {get; set;} 
        public UserTask(User owner, User executor, string header, string description)
        {
            Owner = owner;
            Executor = executor;
            Header = header;
            Description = description;

            ChangeTaskStatus(Status.Open);
        }
        public UserTask(User owner, string header, string description)
        {
            Owner = owner;
            Header = header;
            Description = description;
            WithOutExecutor = true;
            ChangeTaskStatus(Status.Open);
        }
        public void Resolve()
        {
            ChangeTaskStatus(Status.Resolved);
        }
        public void Close()
        {
            IsClosed = true;

            ChangeTaskStatus(Status.Close);
        }

        private void ChangeTaskStatus(Status newStatus)
        {
            switch(newStatus)
            {
                case Status.Open:
                TaskOpenTime = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                break;

                case Status.Resolved:
                TaskResolveTime = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                break;

                case Status.Close:
                TaskCloseTime = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                break;
            }
        }
    }
}
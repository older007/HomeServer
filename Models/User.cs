using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unity3dLogs.Models
{
    public class User
    {
        public string Name { get; set; }
        public List<UserTask> ResolvedTasks = new List<UserTask>();
        public List<UserTask> ClosedTasks = new List<UserTask>();
        public List<UserTask> OpenedTasks = new List<UserTask>();     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyToDoList.MVVM.Model
{
    public class TaskModel
    {
        public string TaskHeader { get; set; }
        public string? TaskDescription { get; set; }
        public DateTime? DateTime { get; set; }
        public CheckBox? CheckBox { get; set; }

        public TaskModel(string taskHeader)
        {
            TaskHeader = taskHeader;
        }
    }
}

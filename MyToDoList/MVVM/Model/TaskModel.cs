using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyToDoList.MVVM.Model
{
    public delegate void ChangeTaskHeader(string text);
    public class TaskModel
    {
        public string TaskHeader { get; set; }
        public string? TaskDescription { get; set; }
        public DateTime? DateTime { get; set; }
        public bool Favorite { get; set; } = false;
        public TaskListModel CurrentList;

        public TaskModel(string taskHeader)
        {
            TaskHeader = taskHeader;
        }

        public event ChangeTaskHeader ChangeTaskHeader;

        public void GetTaskHeader(string newHeader)
        {
            TaskHeader = newHeader;
            ChangeTaskHeader?.Invoke(newHeader);
        }



    }
}

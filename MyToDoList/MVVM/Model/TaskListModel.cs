using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyToDoList.MVVM.Model
{
    internal class TaskListModel
    {
        public string HeaderTaskList { get; set; }
        public string? HeaderTaskItem { get; set; }

        public TaskListModel(string header)
        {
            HeaderTaskList = header;
        }
    }
}

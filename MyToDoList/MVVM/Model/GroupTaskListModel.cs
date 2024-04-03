using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.MVVM.Model
{
    internal class GroupTaskListModel
    {
        public string HearedGroup { get; set; }
        public List<TaskListModel> taskListModels = new List<TaskListModel>();
        public int CountList = 0;
    }
}

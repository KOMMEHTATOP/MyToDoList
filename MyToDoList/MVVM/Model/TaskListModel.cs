using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace MyToDoList.MVVM.Model
{
    public delegate void AddTaskToList(TaskModel taskModel);
    public class TaskListModel
    {
        public List<TaskModel> listTaskModel = new List<TaskModel>();
        public string ListHeaderModel
        {
            get { return "Список без названия"; }
            set
            {
                if (ListHeaderModel != value)
                {
                    ListHeaderModel = value;
                }
            }
        }

        public int countTask = 0;
        public int currentListElement = 0;

        public event AddTaskToList OnAddTaskToList;

        public TaskListModel()
        {
            
        }

        public void AddTaskToList(TaskModel taskModel)
        {
            listTaskModel.Add(taskModel);
            countTask++;
            currentListElement = countTask;
            OnAddTaskToList?.Invoke(taskModel);
            //MessageBox.Show(taskModel.TaskHeader);
        }

        public string GetListHeader()
        {
            return ListHeaderModel;
        }

    }
}

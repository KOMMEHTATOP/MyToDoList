using MyToDoList.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyToDoList.MVVM.ViewModel
{
    public delegate void TaskHeaderChanged(string text);
    public class AddTaskViewModel
    {
        private MainWindow _mainWindow;
        public TaskListModel TaskListModel;

        public string ListHeaderViewModel;

        private string _taskHeaderViewModel;
        public string TaskHeaderViewModel
        {
            get { return _taskHeaderViewModel; }
            private set
            {
                if (_taskHeaderViewModel != value)
                {
                    _taskHeaderViewModel = value;
                    OnTaskHeaderChanged?.Invoke(value);
                }
            }
        }

        public AddTaskViewModel(MainWindow mainWindow, TaskListModel taskListModel)
        {
            _mainWindow = mainWindow;
            TaskListModel = taskListModel;
        }

        public event TaskHeaderChanged OnTaskHeaderChanged;

        public void AddTaskToList(string newTaskHeader)
        {
            TaskModel newTaskViewModel = new TaskModel(newTaskHeader);
            
            TaskListModel.AddTaskToList(newTaskViewModel);
            ListHeaderViewModel = TaskListModel.GetListHeader();
            _mainWindow.ListName.Text = ListHeaderViewModel;
            _mainWindow.HeaderList.Items.Add(ListHeaderViewModel);
        }
    }
}


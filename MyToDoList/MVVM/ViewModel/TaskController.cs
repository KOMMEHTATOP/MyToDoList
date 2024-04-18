using MyToDoList.MVVM.Model;
using MyToDoList.MVVM.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyToDoList.MVVM.ViewModel
{
    public class TaskController : INotifyPropertyChanged
    {
        MainWindow _mainWindow;

        public event PropertyChangedEventHandler? PropertyChanged;

        private string _taskHeaderContoller; 

        public string TaskHeaderController
        {
            get { return _taskHeaderContoller; }
            set
            {
                if (_taskHeaderContoller != value)
                {
                    _taskHeaderContoller = value;
                    OnPropertyChanged(nameof(TaskHeaderController));
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public TaskController(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            AddTask();
        }


        private void AddTask()
        {
            if (!string.IsNullOrEmpty(_mainWindow.InputTaskHeader.Text))
            {
                TaskModel newTask = new TaskModel(_mainWindow.InputTaskHeader.Text);
                _mainWindow.TaskListView.Items.Add(newTask.TaskHeader);
            }
        }
    }
}

using MyToDoList.MVVM.Model;
using MyToDoList.MVVM.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyToDoList.MVVM.ViewModel
{
    public class TaskController : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        MainWindow _mainWindow;
        TaskModel newTask;
        TaskDescriptionView _taskDescriptionView;

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
            _mainWindow.TaskListView.SelectionChanged += TaskListView_SelectionChanged;
        }

        private void TaskListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IsSelectedTask();
        }

        public bool IsSelectedCollectionItem(MainWindow mainWindow)
        {
            object selectedItem = mainWindow.HeaderCollection.SelectedItem;
            if (selectedItem != null)
            {
                return true;
            }
            return false;
        }

        public void IsSelectedTask()
        {
            object selectedTask = _mainWindow.TaskListView.SelectedItem;
            if (selectedTask != null)
            {
                _taskDescriptionView = new TaskDescriptionView();
                _taskDescriptionView.TaskHeader.Text = newTask.TaskHeader;
                _taskDescriptionView.TaskDescription.Text = newTask.Description;
                _taskDescriptionView.ShowDialog();
            }
        }


        private void AddTask()
        {
            if (IsSelectedCollectionItem(_mainWindow))
            {
                if (!string.IsNullOrEmpty(_mainWindow.InputTaskHeader.Text))
                {
                    newTask = new TaskModel(_mainWindow.InputTaskHeader.Text);
                    _mainWindow.TaskListView.Items.Add(newTask.TaskHeader);
                }
            }
        }
    }
}

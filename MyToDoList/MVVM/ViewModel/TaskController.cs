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
    public class TaskController
    {

        MainWindow _mainWindow;
        TaskModel _newTask;
        TaskDescriptionView _taskDescriptionView;
        int currentIndex;

        private string _taskHeaderContoller;

        public string TaskHeaderController
        {
            get { return _taskHeaderContoller; }
            set
            {
                if (_taskHeaderContoller != value)
                {
                    _taskHeaderContoller = value;
                }
            }
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
                _newTask = new TaskModel(_mainWindow.InputTaskHeader.Text);
                _mainWindow.ListTaskModels.Add(_newTask);
                _mainWindow.TaskListView.Items.Add(_newTask.TaskHeader);
            }
        }

        public void ShowFullDescription(int index)
        {
            _taskDescriptionView = new TaskDescriptionView();
            currentIndex = index;
            _taskDescriptionView.TaskHeader.Text = _mainWindow.ListTaskModels[index].TaskHeader;
            _taskDescriptionView.TaskDescription.Text = _mainWindow.ListTaskModels[index].Description;
            _taskDescriptionView.TaskDescription.TextChanged += TaskDescription_TextChanged;
            _taskDescriptionView.Show();

        }

        private void TaskDescription_TextChanged(object sender, TextChangedEventArgs e)
        {
            _mainWindow.ListTaskModels[currentIndex].Description = _taskDescriptionView.TaskDescription.Text;
        }
    }
}

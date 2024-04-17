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
    public class TaskController
    {
        MainWindow _mainWindow;
        CollectionController _collectionController;
        public string HeaderTaskController { get; set; }

        public TaskController(MainWindow mainWindow, CollectionController collectionController)
        {
            _mainWindow = mainWindow;
            _collectionController = collectionController;
            _mainWindow.AddTaskButton.Click += AddTaskButton_Click;
            
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            AddTask();
        }

        private void AddTask()
        {
            if (_mainWindow.HeaderCollection.SelectedItem != null)
            {
                CollectionModel selectedCollection = _mainWindow.HeaderCollection.SelectedItem as CollectionModel;
                if (selectedCollection != null)
                {
                    string taskHeader = _mainWindow.InputTaskHeader.Text;
                    if (!string.IsNullOrEmpty(taskHeader))
                    {
                        TaskModel newTask = new TaskModel(taskHeader, selectedCollection);
                        selectedCollection.BDCollectionModel.Add(newTask);
                    }
                }
                
            }
        }
    }
}

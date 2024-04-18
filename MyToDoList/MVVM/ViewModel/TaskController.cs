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

        public string HeaderTaskController { get; set; }

        public TaskController(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            AddTask();
        }


        private void AddTask()
        {
            var se = _mainWindow.HeaderCollection.SelectedItem;
            MessageBox.Show($"{se.GetType().Name}");
            CollectionController? selectedCollection = _mainWindow.HeaderCollection.SelectedItem as CollectionController;
            string taskHeader = _mainWindow.InputTaskHeader.Text;
            TaskModel newTask = new TaskModel(taskHeader);
            selectedCollection.DCollectionController.Add(newTask);


/*            if (_mainWindow.HeaderCollection.SelectedItem != null)
            {
                if (selectedCollection != null)
                {
                    if (!string.IsNullOrEmpty(taskHeader))
                    {
                    }
                }
            }
*/        }
    }
}

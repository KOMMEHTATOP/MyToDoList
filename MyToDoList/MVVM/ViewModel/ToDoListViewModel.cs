using MyToDoList.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.MVVM.ViewModel
{
    public class ToDoListViewModel
    {
        private MainWindow _mainWindow;
        private ToDoListModel _toDoListModel;


        public ToDoListViewModel(MainWindow mainWindow, ToDoListModel toDoListModel)
        {
            _mainWindow = mainWindow;
            _toDoListModel = toDoListModel;

        }

    }
}

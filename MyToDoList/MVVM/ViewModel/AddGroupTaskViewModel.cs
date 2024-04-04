using MyToDoList.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace MyToDoList.MVVM.ViewModel
{
    public class AddGroupTaskViewModel
    {
        private MainWindow _mainWindow;
        public GroupDictionaryTaskModel TaskDictionaryModel;

        public string GroupListHeaderViewModel { get; set; }

        public AddGroupTaskViewModel(MainWindow mainWindow, GroupDictionaryTaskModel taskDictionaryModel)
        {
            _mainWindow = mainWindow;
            TaskDictionaryModel = taskDictionaryModel;
        }

        public void AddGroupToDictionary()
        {
            GroupDictionaryTaskModel groupDictionaryTaskModel = new GroupDictionaryTaskModel();
            _mainWindow.GroupDictionaryHeader.Items.Add(groupDictionaryTaskModel.GetGroupHeader());
        }
    }
}


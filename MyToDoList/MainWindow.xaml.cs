using MyToDoList.MVVM.Model;
using MyToDoList.MVVM.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyToDoList
{
    public partial class MainWindow : Window
    {
        AddGroupTaskViewModel addGroupViewModel;
        public MainWindow()
        {
            InitializeComponent();
            Loading();
        }

        public void Loading()
        {
            GroupDictionaryTaskModel taskListModel = new GroupDictionaryTaskModel();
            addGroupViewModel = new AddGroupTaskViewModel(this, taskListModel);
            AddTaskButton.Click += AddTaskButton_Click;
            AddGroupHeaderItem.Click += AddGroupHeaderItem_Click;
        }

        private void AddGroupHeaderItem_Click(object sender, RoutedEventArgs e)
        {
            
            addGroupViewModel.AddGroupToDictionary();
        }

        public void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            string a = InputTaskHeader.Text;
        }
    }
}
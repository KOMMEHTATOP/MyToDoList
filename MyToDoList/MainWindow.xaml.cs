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
        AddTaskViewModel addTaskViewModel;
        public MainWindow()
        {
            InitializeComponent();
            Loading();
        }

        public void Loading()
        {
            TaskListModel taskListModel = new TaskListModel();
            addTaskViewModel = new AddTaskViewModel(this, taskListModel);
            AddTaskButton.Click += AddTaskButton_Click;
        }


        public void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            string a = InputTaskHeader.Text;
            addTaskViewModel.AddTaskToList(a);
        }

    }
}
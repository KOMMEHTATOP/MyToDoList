using MyToDoList.MVVM.Model;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AfterInitialize();
        }

        private void AfterInitialize()
        {
            AddTaskToList.PreviewMouseLeftButtonDown += AddTask_PreviewMouseLeftButtonDown;
        }

        private void AddTask_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string taskListHeader = textBox.Text;
            TaskListView.Items.Add(taskListHeader);
        }
    }
}
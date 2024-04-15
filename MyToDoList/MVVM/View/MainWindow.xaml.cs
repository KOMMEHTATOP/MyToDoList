using MyToDoList.MVVM.View;
using MyToDoList.MVVM.ViewModel;
using System.Windows;


namespace MyToDoList.MVVM.View
{
    public partial class MainWindow : Window
    {
        public CollectionController CollectionController;
        public TaskController TaskController;
        public MainWindow()
        {
            InitializeComponent();
            Loading();
        }

        public void Loading()
        {

            AddGroupButton.Click += AddGroupButton_Click;
            AddCollectionButton.Click += AddCollectionButton_Click;
            AddTaskButton.Click += AddTaskButton_Click;
        }

        private void AddGroupButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddCollectionButton_Click(object sender, RoutedEventArgs e)
        {
            CollectionController = new CollectionController(this);
        }

        public void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            TaskController = new TaskController(this, CollectionController);
        }

    }
}
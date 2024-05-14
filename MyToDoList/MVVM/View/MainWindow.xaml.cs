using MyToDoList.MVVM.View;
using MyToDoList.MVVM.ViewModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using MyToDoList.MVVM.Model;


namespace MyToDoList.MVVM.View
{
    public partial class MainWindow : Window
    {
        public CollectionController CollectionController;
        public TaskController TaskController;
        public List<TaskModel> ListTaskModels = new List<TaskModel>();
        public CollectionModel favoriteCollection;

        public MainWindow()
        {
            InitializeComponent();
            Loading();

        }

        public void Loading()
        {
            favoriteCollection = new CollectionModel();
            favoriteCollection.HeaderCollection = "Favorite";
            HeaderCollection.Items.Add(favoriteCollection.HeaderCollection);

            AddGroupButton.Click += AddGroupButton_Click;
            AddCollectionButton.Click += AddCollectionButton_Click;
            AddTaskButton.Click += AddTaskButton_Click;

            TaskListView.SelectionChanged += TaskListView_SelectionChanged;
        }

        private void TaskListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectionIndex = TaskListView.SelectedIndex;
            TaskController.ShowFullDescription(selectionIndex);
        }

        private void AddGroupButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddCollectionButton_Click(object sender, RoutedEventArgs e)
        {
            CollectionController = new CollectionController(this);
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            TaskController = new TaskController(this);
        }
    }
}
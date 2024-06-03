using MyToDoList.MVVM.View;
using System.ComponentModel;
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
            favoriteCollection.PropertyChanged += FavoriteCollection_PropertyChanged;
            favoriteCollection.HeaderCollection = "Favorite";

            AddGroupButton.Click += AddGroupButton_Click;
            AddCollectionButton.Click += AddCollectionButton_Click;
            AddTaskButton.Click += AddTaskButton_Click;

            TaskListView.SelectionChanged += TaskListView_SelectionChanged;
            HeaderCollection.SelectionChanged += HeaderCollection_SelectionChanged;

            HeaderCollection.MouseRightButtonDown += HeaderCollection_MouseRightButtonDown;

        }

        private void HeaderCollection_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var listBoxItem = sender as ListBoxItem;
            if (listBoxItem != null && listBoxItem.DataContext != null)
            {
                string taskName = listBoxItem.DataContext.ToString();
                //OpenEditTaskName(taskName);
            }
        }

        private void FavoriteCollection_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CollectionModel.HeaderCollection))
            {
                var collection = sender as CollectionModel;
                if (collection != null)
                {
                    HeaderCollection.Items.Add(collection.HeaderCollection);
                }
            }
        }

        private void HeaderCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
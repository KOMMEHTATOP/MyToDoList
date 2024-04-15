
using MyToDoList.MVVM.Model;
using System.ComponentModel;
using System.Windows;

namespace MyToDoList.MVVM.View
{
    public class CollectionController :INotifyPropertyChanged
    {
        private MainWindow _mainWindow;
        private List<TaskModel> _dBCollection;
        private string _headerListCollection;

        public List<TaskModel> DBCollection
        {
            get { return _dBCollection; }
            set 
            {
                if (_dBCollection!=value)
                {
                    _dBCollection = value;
                    OnPropertyChanged(nameof(DBCollection));
                }
            }
        }

        public string HeaderListCollection
        {
            get { return _headerListCollection; }
            set
            {
                if (_headerListCollection!=value)
                {
                    _headerListCollection = value;
                    OnPropertyChanged(nameof(HeaderListCollection));
                }
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public CollectionController(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            AddListTasks();
            
        }

        private void AddListTasks()
        {
            CollectionModel newListCollection = new CollectionModel();
            _mainWindow.HeaderCollection.Items.Add(newListCollection.HeaderCollection);
            newListCollection.PropertyChanged += NewListCollection_PropertyChanged;
        }

        private void NewListCollection_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


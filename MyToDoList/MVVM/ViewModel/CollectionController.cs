
using MyToDoList.MVVM.Model;
using MyToDoList.MVVM.ViewModel;
using System.ComponentModel;
using System.Windows;

namespace MyToDoList.MVVM.View
{
    public class CollectionController : INotifyPropertyChanged
    {
        private MainWindow _mainWindow;
        private List<TaskModel> _dBCollection;
        private string _headerListCollection;
        private CollectionModel _collectionModel = new CollectionModel();

        public List<TaskModel> DBCollection
        {
            get { return _dBCollection; }
            set
            {
                if (_dBCollection != value)
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
                if (_headerListCollection != value)
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
            _collectionModel.PropertyChanged += _collectionModel_PropertyChanged;
            AddListTasks();

        }

        private void _collectionModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            MessageBox.Show($"{e}");
        }

        private void AddListTasks()
        {
            _collectionModel = new CollectionModel();
            
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}



using MyToDoList.MVVM.Model;
using MyToDoList.MVVM.ViewModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace MyToDoList.MVVM.View
{
    public class CollectionController : INotifyPropertyChanged
    {
        MainWindow _mainWindow;
        private string _headerListCollection;
        private CollectionModel _collectionModel;
        private ObservableCollection<TaskModel> _bDCollectionController = new ObservableCollection<TaskModel>();

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

        public ObservableCollection<TaskModel> DCollectionController
        {
            get { return _bDCollectionController; }
            set
            {
                if (_bDCollectionController != value)
                {
                    _bDCollectionController = value;
                    OnPropertyChanged(nameof(DCollectionController));
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
            _collectionModel = new CollectionModel(this);
            _mainWindow.HeaderCollection.Items.Add(_collectionModel.HeaderCollection);
        }

       

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


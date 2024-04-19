

using MyToDoList.MVVM.View;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace MyToDoList.MVVM.Model
{
    public class CollectionModel: INotifyPropertyChanged
    {
        CollectionController _collectionController;
        private ObservableCollection<TaskModel> _bDCollectionModel = new ObservableCollection<TaskModel>();
        private string _headerCollection = "Название листа";

        public ObservableCollection<TaskModel> BDCollectionModel
        {
            get { return _bDCollectionModel; }
            set
            {
                if (_bDCollectionModel != value)
                {
                    _bDCollectionModel = value;
                    OnPropertyChanged(nameof(BDCollectionModel));
                }
            }
        }

        public string HeaderCollection
        {
            get { return _headerCollection; }
            set
            {
                if (_headerCollection!=value)
                {
                    _headerCollection = value;
                    OnPropertyChanged(nameof(HeaderCollection));
                }
            }
        }


        public CollectionModel(CollectionController collectionController)
        {
            _collectionController = collectionController;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

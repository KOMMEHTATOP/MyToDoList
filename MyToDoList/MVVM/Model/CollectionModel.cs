

using System.ComponentModel;
using System.Windows;

namespace MyToDoList.MVVM.Model
{
    public class CollectionModel: INotifyPropertyChanged
    {
        
        private List<TaskModel> _bDcollectionModel = new List<TaskModel>();
        private string _headerCollection = "Название листа";

        public List<TaskModel> bDCollectionModel
        {
            get { return _bDcollectionModel; }
            set
            {
                if (_bDcollectionModel != value)
                {
                    _bDcollectionModel = value;
                    OnPropertyChanged(nameof(bDCollectionModel));
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

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            MessageBox.Show("asdf");
        }

        public event PropertyChangedEventHandler? PropertyChanged;


    }
}

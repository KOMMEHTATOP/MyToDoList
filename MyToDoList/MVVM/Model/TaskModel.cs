
using MyToDoList.MVVM.View;
using System.ComponentModel;

namespace MyToDoList.MVVM.Model
{
    public class TaskModel :INotifyPropertyChanged
    {
        private string _taskHeader = "Новый заголовок задачи";
        private string _taskDescription = "Описание задачи";

        private CollectionModel _collectionModel;

        public event PropertyChangedEventHandler? PropertyChanged;

        public TaskModel(string header, CollectionModel collectionModel)
        {
            TaskHeader = header;
            _collectionModel = collectionModel;
        }

        public string TaskHeader
        {
            get { return _taskHeader; }
            set
            {
                if (_taskHeader!=value)
                {
                    _taskHeader = value;
                    OnPropertyChanged(nameof(TaskHeader));
                }
            }
        }

        public string TaskDescription
        {
            get { return _taskDescription; }
            set
            {
                if (_taskDescription!=value)
                {
                    _taskDescription = value;
                    OnPropertyChanged(TaskDescription);
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

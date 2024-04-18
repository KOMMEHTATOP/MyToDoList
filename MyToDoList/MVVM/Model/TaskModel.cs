
using MyToDoList.MVVM.View;
using System.ComponentModel;

namespace MyToDoList.MVVM.Model
{
    public class TaskModel :INotifyPropertyChanged
    {
        private string _taskHeader;

        public event PropertyChangedEventHandler? PropertyChanged;

        public TaskModel(string header)
        {
            TaskHeader = header;
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

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

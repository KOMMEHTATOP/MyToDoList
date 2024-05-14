
using MyToDoList.MVVM.View;
using System.ComponentModel;
using System.Windows.Controls;

namespace MyToDoList.MVVM.Model
{
    public class TaskModel :INotifyPropertyChanged
    {
        private string _taskHeader;
        private string _description = "";

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

        public string Description
        {
            get { return _description; }
            set
            {
                if (_description!=value)
                {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

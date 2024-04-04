using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace MyToDoList.MVVM.Model
{
    public delegate void AddListToDictionary(List<TaskModel> taskModels);
    public class GroupDictionaryTaskModel
    {
        public Dictionary<int, List<TaskModel>> dictionaryTaskModel = new Dictionary<int, List<TaskModel>>();
        public string GroupDictionaryHeaderModel = "Список без названия";

        public event AddListToDictionary OnAddListToDictionary;

        public void AddTaskToDictionary(int index, List<TaskModel> ListTaskModel)
        {
            if (!dictionaryTaskModel.ContainsKey(index))
            {
                dictionaryTaskModel.Add(index, ListTaskModel);
            }
            else
            {
                dictionaryTaskModel[index] = ListTaskModel;
            }
            OnAddListToDictionary?.Invoke(ListTaskModel);
        }

        public string GetGroupHeader()
        {
            string header = GroupDictionaryHeaderModel;
            if (dictionaryTaskModel.Count > 0)
            {
                header += "" + dictionaryTaskModel.Count;
            }
            return header;
        }

    }
}

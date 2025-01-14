using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class QuestStatus: INotifyPropertyChanged
    {
        public Quest PlayerQuest { get; }
        public bool IsCompleted { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public QuestStatus(Quest quest)
        {
            PlayerQuest = quest;
            IsCompleted = false;
        }
    }
}
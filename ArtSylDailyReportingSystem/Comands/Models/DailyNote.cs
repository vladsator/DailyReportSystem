using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArtSylDailyReportingSystem.Comands.Models
{
    public class DailyNote : INotifyPropertyChanged
    {
        private DateTime _cameInTime;
        private DateTime _cameOutTime;
        private List<Task> _tasks;

        public DateTime CameInTime
        {
            get { return _cameInTime; }
            set
            {
                _cameInTime = value; 
                OnPropertyChanged("CameInTime");
            }
        }

        public DateTime CameOutTime
        {
            get { return _cameOutTime; }
            set
            {
                _cameOutTime = value; 
                OnPropertyChanged("CameOutTime");
            }
        }

        public List<Task> Tasks
        {
            get { return _tasks; }
            set
            {
                _tasks = value; 
                OnPropertyChanged("Tasks");
            }
        }

        public DailyNote(DateTime cameInTime)
        {
            CameInTime = cameInTime;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

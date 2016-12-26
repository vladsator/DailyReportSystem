using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ArtSylDailyReportingSystem.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ArtSylDailyReportingSystem.ViewModels
{
    public class StartWorkingViewModel : ViewModelBase
    {
        public DateTime CameInDate { get; set; }

        public DateTime CameInTime {get; set;}

        private DateTime _result;
        public DateTime Result
        {
            get { return _result; }
            set
            {
                _result = value;
                RaisePropertyChanged();
            }
        }

        public StartWorkingViewModel()
        {
            CameInDate = DateTime.Now;
            CameInTime = DateTime.Now;
        }

        private ICommand _acceptCommand;
        
        public ICommand AcceptCommand
        {
            get
            {
                return _acceptCommand ?? (_acceptCommand = new RelayCommand(() =>
                {
                    Result = CameInDate.AddHours(CameInTime.Hour).AddMinutes(CameInTime.Minute);
                }));
            }
        }
    }
}

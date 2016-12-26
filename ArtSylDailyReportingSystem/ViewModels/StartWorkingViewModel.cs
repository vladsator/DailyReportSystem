using System;
using System.Windows.Input;
using ArtSylDailyReportingSystem.Comands.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ArtSylDailyReportingSystem.ViewModels
{
    public class StartWorkingViewModel : ViewModelBase
    {
        public DateTime CameInDate { get; set; }

        public DateTime CameInTime {get; set;}

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
                    var dailyNote = new DailyNote(DateTime.Parse(CameInDate.ToShortDateString() + " " + CameInTime.ToLongTimeString()));

                }));
            }
        }
    }
}

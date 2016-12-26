using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ArtSylDailyReportingSystem.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace ArtSylDailyReportingSystem.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ICommand _startWorking;

        public ICommand StartWorking
        {
            get
            {
                return _startWorking ?? (_startWorking = new RelayCommand(() =>
                {
                    StartWorkingView startWorkingView = new StartWorkingView();
                    startWorkingView.Show();
                }));
            }
        }

    }
}

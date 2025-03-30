using MentalCalc.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalCalc.ViewModel
{
    internal class HomeViewModel
    {
        public Command SettingsCommand { get; }

        public Command StartCommand { get; }

        public HomeViewModel()
        {
            SettingsCommand = new Command(() => Shell.Current.GoToAsync(nameof(SettingsView), true));
            StartCommand = new Command(() => Shell.Current.GoToAsync(nameof(MentalCalculationView), true));
        }
    }
}

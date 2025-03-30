using MentalCalc.Model;
using MentalCalc.Model.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MentalCalc.ViewModel
{
    internal class SettingsViewModel
    {
        public ObservableCollection<SettingsOptionViewModel> SettingsOptions { get; private set; } = new();

        public Command SaveSettingsCommand { get; }
        public SettingsViewModel()
        {
            CreateStandardSettings();
            SaveSettingsCommand = new Command(() => SaveSettings());
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void CreateStandardSettings()
        {
            SettingsOptions.Add(new SettingsOptionViewModel(CalculationType.Add));
            SettingsOptions.Add(new SettingsOptionViewModel(CalculationType.Subtract));
            SettingsOptions.Add(new SettingsOptionViewModel(CalculationType.Multiply));
            SettingsOptions.Add(new SettingsOptionViewModel(CalculationType.Divide));
        }

        private void SaveSettings()
        {
            
        }
    }
}

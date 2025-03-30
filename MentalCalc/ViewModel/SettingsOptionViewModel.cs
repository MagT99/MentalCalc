using MentalCalc.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalCalc.ViewModel
{
    internal class SettingsOptionViewModel
    {
        public string Title { get; }
        public SettingsOptionViewModel(CalculationType calculationType)
        {
                Title = calculationType.ToString();

        }
    }
}

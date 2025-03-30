using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MentalCalc.Model.Common
{
    internal class ObservableObjectBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public void Set(string nameOfProperty, object reference, object newValue)
        {
            reference = newValue;
            OnPropertyChanged(nameOfProperty);
        }

    }
}

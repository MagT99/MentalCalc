using MentalCalc.ViewModel;

namespace MentalCalc.View;

public partial class SettingsView : ContentPage
{
	public SettingsView()
	{
		InitializeComponent();
        BindingContext = new SettingsViewModel();
    }
}
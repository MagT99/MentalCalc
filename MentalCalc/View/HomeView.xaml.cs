using MentalCalc.ViewModel;

namespace MentalCalc.View;

public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();
        BindingContext = new HomeViewModel();
    }
}
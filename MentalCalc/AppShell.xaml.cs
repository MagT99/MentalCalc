using MentalCalc.View;

namespace MentalCalc
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(SettingsView), typeof(SettingsView));
            Routing.RegisterRoute(nameof(MentalCalculationView), typeof(MentalCalculationView));
        }
    }
}

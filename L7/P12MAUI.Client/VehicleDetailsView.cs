using P12MAUI.Client.ViewModels;

namespace P12MAUI.Client;

public partial class VehicleDetailsView : ContentPage
{
	public VehicleDetailsView(VehicleDetailsViewModel vehicleDetailsViewModel)
	{
		BindingContext = vehicleDetailsViewModel;
		InitializeComponent();
	}
}
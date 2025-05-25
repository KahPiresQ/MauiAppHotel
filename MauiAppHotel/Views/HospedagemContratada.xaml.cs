namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void OnVoltarContratada(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();

		}catch (Exception ex)
		{
			DisplayAlert("ops", ex.Message, "Ok");

		}

    }
}
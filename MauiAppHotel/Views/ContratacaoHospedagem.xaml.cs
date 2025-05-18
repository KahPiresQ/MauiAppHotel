using System;
using MauiAppHotel.Views;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
           InitializeComponent();
        }

        private async void OnSaibaMaisClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaibaMais());
        }
    }
}
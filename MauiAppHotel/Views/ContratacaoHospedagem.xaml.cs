using System;
using MauiAppHotel.Views;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {

        App PropriedadesApp;

        public ContratacaoHospedagem()
        {
           InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month  + 1 ,DateTime.Now.Day);


            dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
            dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);        
        }

        private async void OnAvancarClicked(object sender, EventArgs e)

        {
            try
            {
               await Navigation.PushAsync(new HospedagemContratada());

               
            }
            catch (Exception ex)

            { DisplayAlert("Ops", ex.Message, "OK");

            }

           
        }
        private async void OnSaibaMaisClicked(object sender, EventArgs e)

        {
            try
            {
                await Navigation.PushAsync(new SaibaMais());


            }
            catch (Exception ex)

            {
                DisplayAlert("Ops", ex.Message, "OK");

            }
        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {

            DatePicker elemento = sender as DatePicker;

            DateTime data_selecionada_checkin = elemento.Date;

            dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
            dtpck_checkout.MinimumDate = data_selecionada_checkin.AddMonths(6);

        }
    }
}
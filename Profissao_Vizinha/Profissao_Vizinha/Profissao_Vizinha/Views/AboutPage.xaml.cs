using Plugin.ExternalMaps;
using Plugin.Geolocator;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;


namespace Profissao_Vizinha.Views
{
    public partial class AboutPage : ContentPage
    {
        double latitude = 0;
        double longitude = 0;
        public AboutPage()
        {
            InitializeComponent();
            //ObterLocalizacaoCorrente();
            latitude = -19.9922011;
            longitude = -43.9482502;
            Pin pin = new Pin
            {

                Type = PinType.Place,
                Label = "Você está aqui",
                Address = "Rua San Marino, 816 - Vila Castela - Nova Lima - MG",
                Position = new Position(latitude, longitude),
               
                
            };
            pin.InfoWindowClicked += InfoWindow_Clicked;
            map.Pins.Add(pin);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                              new Position(latitude, longitude),
                              Distance.FromMiles(0.4)));
            
            
        }
        private void InfoWindow_Clicked(object sender, PinClickedEventArgs e) { e.HideInfoWindow = false; }
        private async void ObterLocalizacaoCorrente()
        {
            try
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;
                var position = await locator.GetPositionAsync();
                latitude = position.Latitude;
                longitude = position.Longitude;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro : ", ex.Message, "OK");
            }
        }
        private void btnMostrarPosicaoNoMapa_Clicked(object sender, EventArgs e)
        {
            try
            {
                CrossExternalMaps.Current.NavigateTo("Sua localizacao", latitude, longitude);
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro : ", ex.Message, "OK");
            }
        }
    }
}
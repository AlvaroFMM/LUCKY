using LUCKY.viewModels;
using LUCKY.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace LUCKY
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PuntoVenta : ContentPage
    {
        public PuntoVenta()
        {
            InitializeComponent();
            BindingContext = new puntoVentaViewModel();
          
        }

        private async void btnTienda_Clicked(object sender, EventArgs e)
        {
      

        }

        private async void btnMaps_Clicked(object sender, EventArgs e)
        {
            var nombre = "Av Peru";
            double latitud = -12.032609990195551;
            double  longitud = -77.0593458483246;
            if (!double.TryParse(latitud.ToString(), out double lat))
                return;
            if (!double.TryParse(longitud.ToString(), out double lng))
                return;
            await Map.OpenAsync(lat, lng, new MapLaunchOptions
            {

               Name = nombre,
               NavigationMode = NavigationMode.None 

            });

        }
    }
}
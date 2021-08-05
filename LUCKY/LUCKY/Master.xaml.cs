using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LUCKY
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master(string nombre)
        {
            InitializeComponent();
            lblemail.Text = "Bienvenido: \n " + nombre + " ";
        }

        private async void btnAcerca_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new PuntoVenta());
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();

        }
    }
}
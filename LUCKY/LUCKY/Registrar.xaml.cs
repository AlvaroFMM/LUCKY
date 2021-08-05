using LUCKY.Models;
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
    public partial class Registrar : ContentPage
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private async void btnguardar_Clicked(object sender, EventArgs e)
        {
            if (validarData())
            {
                Users uses = new Users
                {
                    nombre = txtnombre.Text,
                    Email = txtemail.Text,
                    password = txtpassword.Text,
                };
                await App.SQLiteDB.SaveUsuariosAsync(uses);
                txtnombre.Text = "";
                txtemail.Text = "";
                txtpassword.Text = "";
                await DisplayAlert("Registro", "Usuario Registrado", "Ok");

            }
            else
            {
                await DisplayAlert("Advertencia", "Llenar todos los campos", "Ok");
            }

        }
        public bool validarData()
        {
            bool res;
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                res = false;
            }
            else if (string.IsNullOrEmpty(txtemail.Text))
            {
                res = false;
            }
            else if (string.IsNullOrEmpty(txtpassword.Text))
            {
                res = false;
            }
            else
            {
                res = true;
            }
            return res;
                 
           
        }
    }
}
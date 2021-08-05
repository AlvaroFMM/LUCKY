using LUCKY.Data;
using LUCKY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LUCKY
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPague : ContentPage
    {
        static SQLiteHelper userData;
        public LoginPague()
        {
            InitializeComponent();
        }

        private async void btningresar_Clicked(object sender, EventArgs e)
        {
            var useremail = txtuser.Text;
          
            //  await App.SQLiteDB.SaveUsuariosAsync(uses);
            if (await ValidateForm())
            {
                var usr = await App.SQLiteDB.GetUsuarios(txtuser.Text.Trim(), txtpassword.Text.Trim());

               if(usr == null)
                {
                    await DisplayAlert("Alerta", "Email o Password Incorrectos.", "OK");
                }
                else
                {
                    await Navigation.PushAsync(new MainPage(useremail));
                }

            }
            //await Navigation.PushAsync(new MainPage());
        }

        private async void btnregistrar_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new Registrar());
        }
        private async Task <bool> ValidateForm()
        {
            //Valida si el valor en el Entry txtTo se encuentra vacio o es igual a Null
            if (String.IsNullOrWhiteSpace(txtuser.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo Email es obligatorio", "Ok");
                return false;
            }
            else
            {
                //Valida que el formato del email sea valido
                bool isEmail = Regex.IsMatch(txtuser.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (!isEmail)
                {
                    await this.DisplayAlert("Advertencia", "El formato del Email es incorrecto.", "OK");
                    return false;
                }
            }

            //Valida si el valor en el Entry txtpassword se encuentra vacio o es igual a Null
            if (String.IsNullOrWhiteSpace(txtpassword.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo Password es obligatorio.", "OK");
                return false;
            }

            return true;
        }
    
    }
}
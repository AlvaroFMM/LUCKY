using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LUCKY 
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage(string us)
        {
            InitializeComponent();
            this.Master = new Master(us);
            this.Detail = new NavigationPage(new Detail());
            App.MasterDet = this;
        }
    }
}

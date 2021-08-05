using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LUCKY.Data;
using System.IO;

namespace LUCKY
{
    
    public partial class App : Application
    {
        public static MasterDetailPage MasterDet { get; set; }
        static SQLiteHelper db;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPague());
        }
        public static SQLiteHelper SQLiteDB
        {
            get
            {
                if (db==null) // si no existe la BD, se procede a crearla
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBUser.db3"));

                }
                return db;
            }
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

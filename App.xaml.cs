using AppCustoViagem.Model;
using AppCustoViagem.View;
using System.Collections.Generic;
using Xamarin.Forms;

using System.Globalization;
using System.Threading;

namespace AppCustoViagem
{
    public partial class App : Application
    {
        public static List<Pedagio> ListaPedagios = new List<Pedagio>();

        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            MainPage = new NavigationPage(new Listagem());
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

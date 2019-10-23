using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public void MudarCadastroPF2(object sender, EventArgs args)
        {
            App.Current.MainPage = new CadastroPF();
        }
        public void MudarODP2(object sender, EventArgs args)
        {
            App.Current.MainPage = new NavigationPage(new OpcoesDeEscolha2())
            {
                BarBackgroundColor = Color.DarkOrange
            };
        }
         

}
}
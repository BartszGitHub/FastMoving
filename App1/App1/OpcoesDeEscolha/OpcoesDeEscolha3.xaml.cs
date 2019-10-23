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
    public partial class OpcoesDeEscolha3 : ContentPage
    {
        public OpcoesDeEscolha3()
        {
            InitializeComponent();
        }
        private void MudarOPE4(object sender, EventArgs args)
        {
            Navigation.PushAsync(new OpcoesDeEscolha4());
        }
    }
}
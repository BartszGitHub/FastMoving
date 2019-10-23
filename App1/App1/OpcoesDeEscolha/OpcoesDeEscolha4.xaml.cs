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
    public partial class OpcoesDeEscolha4 : ContentPage
    {
        public OpcoesDeEscolha4()
        {
            InitializeComponent();
        }

        private void MudarOPE5(object sender, EventArgs args)
        {
            Navigation.PushAsync(new OpcoesDeEscolha5());
        }
    }
}
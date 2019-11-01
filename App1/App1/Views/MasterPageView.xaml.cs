using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPageView : ContentPage

    {
        public Models.MenuItem[] OpcoesMenu { get; set; }
        public ListView ListView { get; set; }
        public MasterPageView()
        {
            Icon = "OficinaApp.png";
            InitializeComponent();

            OpcoesMenu = new[]
            {
                new Models.MenuItem
                {
                    Id = 0,
                    Title = "Pagamentos",
                    TargetType = typeof(Pagamentos),
                    IconSource ="Clientes.png"
                },

                new Models.MenuItem {
                    Id = 1,
                    Title = "Cadastro",
                    TargetType = typeof(CadastroPF),
                    IconSource ="Servicos.png"}
            };
            ListView = itensMenuListView;
            BindingContext = this;
        }
    }
}
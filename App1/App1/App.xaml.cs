using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

             MainPage = new MainPage();
             // MainPage = new LoginPage();
            // MainPage = new CadastroPF();
            // MainPage = new OpcoesDeEscolha2();
            // MainPage = new OpcoesDeEscolha3();
            // MainPage = new OpcoesDeEscolha4();
            // MainPage = new OpcoesDeEscolha5();
            // MainPage = new Cartao();
            // MainPage = new Pagamentos();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

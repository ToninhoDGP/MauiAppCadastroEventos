using MauiAppCadastroEventos.Views;

namespace MauiAppCadastroEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Define a página de cadastro como a tela inicial do aplicativo com suporte a navegação
            MainPage = new NavigationPage(new CadastroEventoPage());
        }
    }
}
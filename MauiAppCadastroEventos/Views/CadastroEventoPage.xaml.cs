using MauiAppCadastroEventos.Models;

namespace MauiAppCadastroEventos.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        public CadastroEventoPage()
        {
            InitializeComponent();

            // Define as datas padrão no DatePicker
            dtpck_inicio.Date = DateTime.Now;
            dtpck_termino.Date = DateTime.Now.AddDays(1);

            // Define os limites mínimos de data
            dtpck_inicio.MinimumDate = DateTime.Now;
            dtpck_termino.MinimumDate = DateTime.Now.AddDays(1);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Evento evento = new Evento
                {
                    Nome = txt_nome.Text,
                    DataInicio = dtpck_inicio.Date ?? DateTime.Now,
                    DataTermino = dtpck_termino.Date ?? DateTime.Now.AddDays(1),
                    NumeroParticipantes = Convert.ToInt32(stp_participantes.Value),
                    Local = txt_local.Text,
                    CustoPorParticipante = Convert.ToDouble(txt_custo.Text)
                };

                await Navigation.PushAsync(new ResumoEventoPage
                {
                    BindingContext = evento
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}
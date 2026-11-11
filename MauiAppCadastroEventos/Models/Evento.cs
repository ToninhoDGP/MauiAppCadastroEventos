namespace MauiAppCadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        // Propriedade calculada para obter a duração do evento em dias
        public int DuracaoEmDias
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }

        // Propriedade calculada para obter o custo total do evento
        public double CustoTotal
        {
            get => NumeroParticipantes * CustoPorParticipante;
        }
    }
}
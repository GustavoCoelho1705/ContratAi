namespace ContratAi.Application.Input.Evento
{
    public class AdicionaEventoInput
    {
        public Guid OrganizadorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Localizacao { get; set; }
        public int Capacidade { get; set; }
        public int Status { get; set; }
    }
}

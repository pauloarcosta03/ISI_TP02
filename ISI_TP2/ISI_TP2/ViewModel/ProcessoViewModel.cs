namespace ISI_TP2.ViewModel
{
    public class ProcessoViewModel
    {
        public int NrProcesso { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoProcesso { get; set; }
        public int IdAdvogado { get; set; }
        public string Descricao { get; set; }
        public int IdEstado { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFecho { get; set; }
        public string ValorProcesso { get; set; }
        public string Obs { get; set; }
    }
}

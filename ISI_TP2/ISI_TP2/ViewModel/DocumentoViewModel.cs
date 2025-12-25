namespace ISI_TP2.ViewModel
{
    public class DocumentoViewModel
    {
        public int IdTipoDocumento { get; set; }
        public int? IdCliente { get; set; }
        public int? IdAdvogado { get; set; }
        public int? NrProcesso { get; set; }
        public int? IdAudiencia { get; set; }
        public string Doc { get; set; }
        public string Obs { get; set; }
    }
}

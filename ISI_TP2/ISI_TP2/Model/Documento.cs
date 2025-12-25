using System.ComponentModel.DataAnnotations;

namespace ISI_TP2.Data
{
    public class Documento
    {
        [Key]
        public int IdDocumento { get; set; }
        public int IdTipoDocumento { get; set; }
        public int? IdCliente { get; set; }
        public int? IdAdvogado { get; set; }
        public int? NrProcesso { get; set; }
        public int? IdAudiencia { get; set; }
        public string Doc { get; set; }
        public string Obs { get; set; }
    }
}

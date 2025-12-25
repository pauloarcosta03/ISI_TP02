using System.ComponentModel.DataAnnotations;

namespace ISI_TP2.Data
{
    public class TipoDocumento
    {
        [Key]
        public int IdTipoDocumento { get; set; }
        public string Nome { get; set; }
    }
}

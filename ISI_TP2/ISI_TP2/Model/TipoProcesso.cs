using System.ComponentModel.DataAnnotations;

namespace ISI_TP2.Data
{
    public class TipoProcesso
    {
        [Key]
        public int IdTipoProcesso { get; set; }
        public string Nome { get; set; }
    }
}

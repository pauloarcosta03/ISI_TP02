using System.ComponentModel.DataAnnotations;

namespace ISI_TP2.Data
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }
        public string Nome { get; set; }
    }
}

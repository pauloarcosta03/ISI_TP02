using System.ComponentModel.DataAnnotations;

namespace ISI_TP2.Data
{
    public class Audiencia
    {
        [Key]
        public int IdAudiencia { get; set; }
        public int NrProcesso { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
    }
}

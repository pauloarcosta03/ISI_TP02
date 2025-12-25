using System.ComponentModel.DataAnnotations;

namespace ISI_TP2.Data
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Cidade { get; set; }
        public string CodPostal { get; set; }
        public DateTime DataNasc { get; set; }
        public int NIF { get; set; }
        public string Email { get; set; }
        public int Tel { get; set; }
        public DateTime DataRegisto { get; set; }
        public bool Ativo { get; set; }
        public string Obs { get; set; }
    }
}

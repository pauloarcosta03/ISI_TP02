using System.ComponentModel.DataAnnotations;

namespace ISI_TP2.Data
{
    public class Especialidade
    {
        [Key]
        public int IdEspecialidade { get; set; }
        public string Nome { get; set; }

        public Especialidade()
        { }

        public Especialidade(string Nome)
        {
            this.Nome = Nome;
        }
    }
}

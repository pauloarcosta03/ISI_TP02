using ISI_TP2.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace ISI_TP2.Data
{
    public class Advogado
    {
        [Key]
        public int IdAdvogado { get; set; }
        public int NrOrdem { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telemovel { get; set; }
        public DateTime DataNasc { get; set; }
        public string Morada { get; set; }
        public string Cidade { get; set; }
        public string CodPostal { get; set; }
        public int IdEspecialidade { get; set; }
        public DateTime DataInicioExe { get; set; }
        public DateTime DataRegisto { get; set; }
        public bool Ativo { get; set; }
    

    public Advogado(int NrOrdem, string Nome, string Email, int Telemovel, DateTime DataNasc, string Morada, string Cidade, string CodPostal, int IdEspecialidade, DateTime DataInicioExe)
        {
            this.NrOrdem = NrOrdem;
            this.Nome = Nome;
            this.Email = Email;
            this.Telemovel = Telemovel;
            this.DataNasc = DataNasc;
            this.Morada = Morada;
            this.Cidade = Cidade;
            this.CodPostal = CodPostal;
            this.IdEspecialidade = IdEspecialidade;
            this.DataInicioExe = DataInicioExe;
            this.Ativo = true;
        }
    }
}

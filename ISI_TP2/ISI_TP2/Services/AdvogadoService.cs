using ISI_TP2.Data;
using ISI_TP2.Model;
using ISI_TP2.ViewModel;

namespace ISI_TP2.Services
{
    public class AdvogadoService
    {
        private readonly LegalFirmContext _context;

        public AdvogadoService(LegalFirmContext context)
        {
            _context = context;
        }

        public void AdicionarAdvogado(Advogado advogado)
        {
            _context.Advogados.Add(advogado);
            _context.SaveChanges();
        }
    }
}

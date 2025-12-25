using ISI_TP2.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;

namespace ISI_TP2.Model
{
    public class LegalFirmContext : DbContext
    {

        // CONSTRUTOR OBRIGATÓRIO para o AddDbContext funcionar
        public LegalFirmContext(DbContextOptions<LegalFirmContext> options)
            : base(options)
        {
        }

        // Construtor sem parâmetros (mantenha se já existir)
        public LegalFirmContext()
        {
        }

        public DbSet<Advogado> Advogados { get; set; }
        public DbSet<Audiencia> Audiencias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Processo> Processos { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<TipoProcesso> TiposProcesso { get; set; }

        
    }
}

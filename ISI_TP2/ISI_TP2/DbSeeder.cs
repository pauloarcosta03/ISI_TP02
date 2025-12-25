using ISI_TP2.Data;
using ISI_TP2.Model;
using System;

namespace ISI_TP2
{
    public static class DbSeeder
    {
        public static void Seed(LegalFirmContext context)
        {
            if (!context.Especialidades.Any())
            {
                context.Especialidades.Add(
                    new Especialidade
                    {
                        Nome = "Direito Civil"
                    }
                );

                context.SaveChanges();
            }
        }
    }

}

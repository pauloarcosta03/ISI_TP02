using ISI_TP2.Data;
using ISI_TP2.Services;
using ISI_TP2.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISI_TP2.Controllers
{
    [Route("advogado")]
    [ApiController]
    public class AdvogadoController : ControllerBase
    {

        private readonly AdvogadoService _advogadoService;
        public AdvogadoController(AdvogadoService advogadoService)
        {
            _advogadoService = advogadoService;
        }

        /// <summary>
        /// Adiciona um advogado
        /// </summary>
        /// <param name="avm"></param>
        /// <returns></returns>
        [HttpPost("novo")]
        public IActionResult Adicionar(AdvogadoViewModel avm)
        {
         
            Advogado novoAdvogado = new Advogado(avm.NrOrdem, avm.Nome, avm.Email, avm.Telemovel, avm.DataNasc, avm.Morada, avm.Cidade, avm.CodPostal, avm.IdEspecialidade, avm.DataInicioExe);

            _advogadoService.AdicionarAdvogado(novoAdvogado);


            return Ok();
        }
    }
}

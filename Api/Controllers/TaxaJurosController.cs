using Aplicacao.TaxaJuros;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("TaxaJuros")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly IAplicTaxaJuros _aplicTaxaJuros;

        public TaxaJurosController(IAplicTaxaJuros aplicTaxaJuros)
        {
            _aplicTaxaJuros = aplicTaxaJuros;
        }
        [HttpGet]
        public decimal TaxaPadrao()
        {
            return _aplicTaxaJuros.ObterTaxaPadrao();
        }
    }
}

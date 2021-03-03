using Aplicacao.TaxaJuros;
using AutoMoqCore;
using Xunit;

namespace Aplicacao.Testes
{
    public class AplicTaxaJurosTestes
    {
        const decimal TaxaEsperada = 0.01m;

        private readonly AutoMoqer _moker;
        private AplicTaxaJuros aplicTaxaJuros;
        public AplicTaxaJurosTestes()
        {
            _moker = new AutoMoqer();
            aplicTaxaJuros = _moker.Resolve<AplicTaxaJuros>();

        }
        [Fact]
        public void ObterTaxaPadrao_DeveRetornar_001()
        {
            var taxa = aplicTaxaJuros.ObterTaxaPadrao();

            Assert.Equal(TaxaEsperada, taxa);
        }
    }
}

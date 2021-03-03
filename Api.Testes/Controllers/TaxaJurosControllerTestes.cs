using Api.Controllers;
using Aplicacao.TaxaJuros;
using AutoMoqCore;
using Moq;
using Xunit;

namespace Api.Testes
{
    public class TaxaJurosControllerTestes
    {
        const decimal TaxaEsperada = 0.01m;
        private readonly AutoMoqer _moker;
        private readonly Mock<IAplicTaxaJuros> _aplicTaxaJuros;

        public TaxaJurosControllerTestes()
        {
            _moker = new AutoMoqer();
            _aplicTaxaJuros = _moker.GetMock<IAplicTaxaJuros>();
        }
        [Fact]
        public void ObterTaxaPadrao_DeveRetornar_001()
        {
            _aplicTaxaJuros.Setup(x => x.ObterTaxaPadrao()).Returns(TaxaEsperada);
            var taxaJurosController = new TaxaJurosController(_aplicTaxaJuros.Object);

            var taxaPadrao = taxaJurosController.TaxaPadrao();

            Assert.Equal(TaxaEsperada, taxaPadrao);

        }
    }
}

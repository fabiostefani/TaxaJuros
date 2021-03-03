using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace Api.TestesIntegracao
{
    public class TaxaJurosControllerTestes
    {
        const decimal TaxaEsperada = 0.01m;
        private readonly string _endPoint = "/taxajuros";
        private HttpClient _httpClient;
        public TaxaJurosControllerTestes()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _httpClient = server.CreateClient();
        }

        [Fact]
        public async Task OterTaxaPadrao_DeveRetornarRepostaOk()
        {
            var resp = await _httpClient.GetAsync(_endPoint);
            resp.EnsureSuccessStatusCode();

            Assert.True(resp.IsSuccessStatusCode);
        }

        [Fact]
        public async Task OterTaxaPadrao_DeveRetornar_0_01()
        {
            var resp = await _httpClient.GetAsync(_endPoint);
            resp.EnsureSuccessStatusCode();

            var valorAtual = await JsonSerializer.DeserializeAsync<decimal>(await resp.Content.ReadAsStreamAsync());

            Assert.Equal(TaxaEsperada, valorAtual);
        }
    }
}

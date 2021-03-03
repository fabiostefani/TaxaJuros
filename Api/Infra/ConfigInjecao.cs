using Aplicacao.TaxaJuros;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Infra
{
    public static class ConfigInjecao
    {
        public static void RegistrarInjecao(this IServiceCollection services)
        {
            services.AddScoped<IAplicTaxaJuros, AplicTaxaJuros>();
        }
    }
}

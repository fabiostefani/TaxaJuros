# API TaxaJuros

Retorna taxa de juros  

Responde pelo path relativo "/taxaJuros"

Retorna o juros de 1% ou 0,01 (fixo no código)
* Exemplo: /taxaJuros Resultado esperado: 0,01

## Arquitetura

Optei em estruturar o projeto em Camadas, cada qual com sua responsabilidade.
Temos um projeto API, aonde teremos os endpoints que serão disponibilizados para serem consumidos.
Outra camada adicionada foi a Aplicação. Esta seria responsável pelos casos de uso do produto e assim podemos ter várias outras camadas.
Foi adicionado também as camadas de Testes. Cada projeto com seu projeto de testes.
O projeto Aplicacao.Testes tem por objetivo efetuar os Testes de Unidade para os componentes menores.
O projeto Api.Testes aplicará os Testes de Integração garantindo que o método está efetuando a chamada do método correto da aplicação.
E por fim, o projeto de testes Api.TestesIntegracao que tem por objetivo garantir que o EndPoint do API esteja funcionando de forma correta para demais serviços que estarão consumindo a mesma.

### Techs utilizadas
 - [**ASP.NET Core**](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-5.0)
 - [**Swagger**](https://www.nuget.org/packages/Swashbuckle/)
 - [**AutoMoqCore**](https://www.nuget.org/packages/AutoMoqCore/)
 - [**XUnit**](https://www.nuget.org/packages/xunit/)
 - [**TestHost**](https://www.nuget.org/packages/Microsoft.AspNetCore.TestHost)



### Rodando a aplicação

Rodando local

```
> git clone https://github.com/fabiostefani/TaxaJuros.git
> cd TaxaJuros
> dotnet run --project .\Api\Api.csproj
```

Rodando com [**Docker**](https://www.docker.com/)
```
> git clone https://github.com/fabiostefani/TaxaJuros.git
> cd TaxaJuros
> docker compose up
```
A imagem docker para esta API está publicada [Docker HUB](https://hub.docker.com/r/fabiostefani/apitaxajuros).
Para iniciar essa imagem
```
> docker run -p 8001:80 fabiostefani/apitaxajuros:latest
```

E também a deixei rodando no [Azure Container Registry](http://apitaxajuros.brazilsouth.azurecontainer.io/)


### Link
ApiTaxaJuros [http://localhost:8001/](http://localhost:8001)

ApiCalculoJuros [http://localhost:8002/](http://localhost:8002)


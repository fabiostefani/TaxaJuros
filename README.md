# API TaxaJuros

Objetivo do projeto é desenvolver uma API para retornar uma Taxa de Juros fixa no valor de 0.01 (1%).

## Arquitetura

Optei em estruturar o projeto em Camadas, cada qual com sua responsabilidade.
Temos um projeto API, aonde teremos os endpoints que serão disponibilizados para serem consumidos.
Outra camada adicionada foi a Aplicação. Esta seria responsável pelos casos de uso do produto e assim podemos ter várias outras camadas.
Foi adicionado também as camadas de Testes. Cada projeto com seu projeto de testes.
O projeto Aplicacao.Testes tem por objetivo efetuar os Testes de Unidade para os componentes menores.
O projeto Api.Testes aplicará os Testes de Integração garantindo que o método está efetuando a chamada do método correto da aplicação.
E por fim, o projeto de testes Api.TestesIntegracao que tem por objetivo garantir que o EndPoint do API esteja funcionando de forma correta para demais serviços que estarão consumindo a mesma.

### Techs utilizadas


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

Rodando com [**Docker**](https://www.docker.com/) a api Taxa de Juros
```
> git clone https://github.com/fabiostefani/TaxaJuros.git
> 
```

Rodando com [**Docker**](https://www.docker.com/) ambas as APIs
```
> git clone https://github.com/fabiostefani/TaxaJuros.git
> docker-compose up
```

### Link
[ApiTaxaJuros](http://localhost:5001/swagger)

[ApiCalculoJuros](http://localhost:5000/swagger)


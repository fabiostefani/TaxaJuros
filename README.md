# API TaxaJuros

Nesse projeto, foi desenvolvido uma API para retornar uma Taxa de Juros que é definida de forma fixa dentro do código com o valor de 0.01 (1%).

Para a arquitetura do projeto, apliquei uma separação em camadas.
Na camada API, teremos os endpoints que serão disponibilizados ao exterior, aonde outras APIs irão fazer requests.
Na camada de Dominio irá conter as regras de negócios do projeto, para esse exemplo, a regra fixa da Taxa de Juros.


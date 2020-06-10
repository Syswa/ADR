# ADR - Analise de Desempenho da Rede
## Pre-requisitos da Aplicação
- .Net Framework 3.1
- Navegador ex.: Google Ghrome,IE 11

## Linguagens
- HTML
- JavaScript
- ASP.Net
- Css

## Padrão de Desenvolvimento
-MVC (Model - View - Control)

# Produção
## User Story
- Inserir o IP ou o servidor do terminal que pretende analisar o desempenho
- Clicar em analisar
- O sistema mostrar-ra o desempenho da rede em forma de gráfico e em tabela duma forma dinâmica ate que o usuário cancele.

## Deployment
- Sistema operativo: Windows e Linux
- Compatível com dispositivos movel
- Servidor web compativel para o projecto é o IIS (Internet Information Services)
- .Net Framework 3.1
- Compativel com o FireFox v30<X, Chrome e Internet Explore  superior e igual a 10 versão
- Compatível com as versões anterior do Framework  de 2.0 até 3.1

## Arquitetura
O projecto ADR foi utilizado o Modelo  MVC (Model-View-Controller) e o Net. Framework
No desenvolvimento deste projecto, foi utilizada a A arquitetura PL e BLL (Presentation layer and Business Logic Layer)/Camadas de Apresentação e Camadas de lógica de Negócios.
### Camada PL (Camada de Apresentação):
- Nesta camada contem a interface do sistema onde interage com a camada de negócios. A interação do cliente neste fase foi feita atravez da interface construida com a ASP.Net em conjunto de Javsacript, css, jquery, HTML e biblíotecas do Bootstrap para que haja compabilidade com vários tamalhos de despositivos.
- Para a aquisição de dados na camada de negócios foi utilizado o metodo POST através do protocolo HTTP

### Camada BLL (Camada de lógica de negócios)
- Esta camada foi criada para receber a requisição da camada de apresentação e retornar o resultado pedido pelo usuário.
Nesta camada foi feita classes para receber pedidos e retornar a camada de apresentação.



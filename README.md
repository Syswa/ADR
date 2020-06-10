# ADR - Analise de Desempenho da Rede
## Pre-requisitos da Aplicacao
- .Net Framework 3.1
- Navegador ex.: Google Ghrome,IE 11

## Linguagens
- HTML
- JavaScript
- ASP.Net
- Css

## Padrao de Desenvolvimento
-MVC (Model - View - Control)


# Produção

## User Story
- Inserir o IP ou o servidor do terminal que pretende analisar o desempenho
- Clicar em analisar
- O sistema mostrar-ra o desempenho da rede em forma de gráfico e em tabela duma forma dinamica ate que o usuário cancele.

## Deployment
- Sistema operativo: Windows e Linux
- Compativel com dispositivos movel
- Servidor web compativel para o projecto é o IIS (Internet Information Services)
- .Net Framework 3.1
- Compativel com o FireFox, Chrome e Internet Explore  superior e igual a 10 ersao
- Compativel com as versoes anterior do Framework  de 2.0 ate 3.1

## Arquitetura
O projecto ADR foi utilizado o Modelo  MVC (Model-View-Controller) e o Net. Framework
No desenvolvimento deste projecto, foi utilizada a A arquitetura PL e BLL (Presentation layer and Business Logic Layer)/Camadas de Apresentaca e Camadas de logica de Negocios.
### Camada PL (Camada de Apresentacao):
- Nesta camada contem a interface do sistema interage com a camada de negocios. A interacao do cliente neste fase foi feita atravez da interface construida com a ASP.Net em conjunto de Javsacript, css, jquery, HTML e bibliotecas do Bootstrap para que haja compabilidade com varios tamalhos de despositivos.
- Para a aquisicao de dados na camada de negocios foi utilizado o metodo POST atravez do protocolo HTTP

### camada BLL (Camada de logica de negocios)
- Esta camada foi criada para receber a requisição da camada de apresentação e retornar o resultado pedido pelo usuario.
Nesta camada foi feita classes para receber pedidos e retornar a camada de apresentacao



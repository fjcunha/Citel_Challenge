# Citel_Challenge

Projeto ASPNET MVC com estrutura DDD, WEB API, WEB Application.
Banco de dados mysql usando Entity Framework, Code First
Camada Web Api com documentação Swagger

# Instruções

-> Clone este projeto
-> Configure a connection string no web.config do projeto CitelProject.API
-> Setar projeto CitelProject.API como StartUp project

Com a connection string configurada corretamente, e projeto API como StartUp Project, abra o Package Manager Console e digite o comando:

`Update-Database`

por fim no Projeto CitelProject.MVC > Extensions > APIExtension, troque o valor da URL_BASE no construtor para a url onde o Projeto API estará disponível.
Obs: Você pode configurar essa URL clicando com direito no projeto->Propriedades->Web Project Url


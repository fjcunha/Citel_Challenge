# Citel_Challenge

Projeto ASPNET MVC com estrutura DDD, WEB API, WEB Application.
Banco de dados mysql usando Entity Framework, Code First
Camada Web Api com documentação Swagger

# Instruções

-> Clone este projeto

-> Abra no Visual Studio e build para que as dependencias sejam restauradas

-> Configure a connection string no web.config do projeto CitelProject.API

Exemplo

`<add name="CitelProjectConnection" providerName="MySql.Data.MySqlClient" connectionString="server=localhost;port=3306;userid=[USER];password=[PASSWORD];database=[DATABASE];persistsecurityinfo=True" />`

-> Setar projeto CitelProject.API como StartUp project
(Clicar com direito no projeto > Set as StartUp Project)

Com a connection string configurada corretamente, e projeto API como StartUp Project: 

-> abra o Package Manager Console 

-> Selecione o Default project : 4 - Infra\4.1 - Data\CitelProject.Infra.Data 

-> e digite o comando:

`Update-Database`

por fim no Projeto CitelProject.MVC > Extensions > APIExtension, troque o valor da URL_BASE no construtor para a url onde o Projeto API estará disponível.
Obs: Você pode configurar essa URL clicando com direito no projeto->Propriedades->Web Project Url


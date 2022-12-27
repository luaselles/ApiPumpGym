# Exemplo API

##  Criando Api com Arquitetura Hexagonal C#

### Criando a webapi principal. Comando:
>> dotnet new webapi -n Exemplo.Api
### Criando Classlib. Comando:
>> dotnet new classlib -n  Exemplo.Apllication 
>> dotnet new classlib -n  Exemplo.Domain
>> dotnet new classlib -n  Exemplo.Infra.Data 
### Adicionar um novo pacote. Comando: 
>> dotnet add package Pacote.Exemplo
### Instalando a ferramenta 'dotnet-ef'. Comando: 
>> dotnet tool install -g dotnet-ef
### Criar nova migration. Deve estar dentro do projeto inicializável para criação da migration. Comando: 
>> dotnet ef migrations add InitialCreate --project ..\Exemplo.Infra.Data\ 

<br>
<hr>

## Enable secret storage


### File system path windows:
>> %APPDATA%\Microsoft\UserSecrets\<user_secrets_id>\secrets.json
### init command
>> dotnet user-secrets init
### Set a secret
>> dotnet user-secrets set "Movies:ServiceApiKey" "12345"

<br>
<hr>

## Linha de comandos Entity Framework Core .NET Command-line Tools.
### Camada Infra Data
>> dotnet ef --project ..\Exemplo.Infra.Data\
### Criando Base de Dados pelo terminal.
>> dotnet ef database update
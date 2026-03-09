# 📅 Agenda de Tarefas - API

Esta é uma API desenvolvida em **ASP.NET Core** para o gerenciamento de tarefas. O projeto utiliza o **Entity Framework Core** como ORM para facilitar a comunicação com o banco de dados **SQL Server**.

## 🚀 Funcionalidades

* Criar novas tarefas.
* Listar todas as tarefas ou buscar por ID.
* Atualizar informações de uma tarefa existente.
* Remover tarefas da agenda.
* Persistência de dados em banco SQL Server.

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** ASP.NET Core
* **ORM:** Entity Framework Core
* **Banco de Dados:** SQL Server (executando em container Podman/Docker)
* **Documentação:** Swagger (OpenAPI)

## 🏗️ Estrutura do Projeto

* **Controllers:** Endpoints da API e lógica de rotas.
* **Context:** Configuração do DbContext do Entity Framework.
* **Entitis:** Modelagem das tabelas do banco de dados (Entidades).
* **Migrations:** Histórico de versionamento do esquema do banco.

## 🔧 Como Executar o Projeto

### Pré-requisitos
* [.NET SDK](https://dotnet.microsoft.com/download) instalado.
* SQL Server em execução (Recomendado utilizar Podman ou Docker).

### Configuração do Banco de Dados
1. Certifique-se de que a string de conexão no arquivo `appsettings.json` está correta.
2. No terminal, execute as migrations:
   `dotnet ef database update`

### Executando a API
1. Restaure as dependências:
   `dotnet restore`
2. Execute o projeto:
   `dotnet run`
3. A API estará disponível em `http://localhost:5000`. Acesse `/swagger` no seu navegador para testar os endpoints.

## ✒️ Autor

* **Luciano** - [luciano-cc-dev](https://github.com/luciano-cc-dev)

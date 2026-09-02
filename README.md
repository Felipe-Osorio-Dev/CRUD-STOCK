# CRUD-STOCK

Projeto de exemplo para gerenciamento de estoque (CRUD) desenvolvido em .NET 8.

Resumo rápido
- API RESTful em ASP.NET Core (Web API)
- Entity Framework Core com provider Npgsql (PostgreSQL)
- Mapster para mapeamento entre DTOs e models

Tecnologias
- .NET 8
- C#
- ASP.NET Core Web API
- Entity Framework Core (Npgsql)
- Mapster

Pré-requisitos
- .NET 8 SDK
- PostgreSQL (ou um container PostgreSQL)
- Git (opcional)

Instalação local
1. Clone o repositório:
   git clone https://github.com/Felipe-Osorio-Dev/CRUD-STOCK.git
2. Abra a solução no Visual Studio ou via linha de comando:
   dotnet restore

Configuração (connection string)
- Configure a connection string do PostgreSQL em `API/appsettings.Development.json` ou variáveis de ambiente.
- Chave esperada: `ConnectionStrings:AppConnectionString`
- Exemplo (appsettings.Development.json):

  {
	"ConnectionStrings": {
	  "AppConnectionString": "Host=localhost;Port=5432;Username=seu_usuario;Password=sua_senha;Database=stock_db"
	}
  }

Migrações (EF Core)
- Aplicar migrações para criar o banco:
  dotnet ef database update --project API --startup-project API

Executando a API
- Via CLI:
  dotnet run --project API
- A aplicação, por padrão, expõe os endpoints em `/api/products`.

Endpoints principais (Products)
- GET /api/products — lista todos os produtos
- POST /api/products — registra um novo produto
  Exemplo de body JSON:
  {
	"name": "Produto A",
	"description": "Descrição",
	"price": 10.50,
	"quantity": 100
  }
- GET /api/products/{id} — obtém produto por id
- PUT /api/products/{id} — atualiza completamente o produto
- PATCH /api/products/{id} — atualização parcial
- DELETE /api/products/{id} — remove produto

Swagger
- Em ambiente de desenvolvimento o Swagger UI está habilitado (use a URL exibida no console, normalmente `/swagger`).

Docker (opcional)
- Sugestão rápida: rode um container Postgres e a API apontando a connection string para o host do container.

Contribuição
- Fork -> branch -> PR. Use commits pequenos e descritivos.

Licença
- Escolha uma licença e adicione o arquivo LICENSE (ex.: MIT).

Contato
- Autor: Felipe Osorio

Exemplos de requests

Base URL (exemplo): https://localhost:5001

Curl - listar todos
curl -k -X GET "https://localhost:5001/api/products" -H "Accept: application/json"

Curl - obter por id
curl -k "https://localhost:5001/api/products/1"

Curl - criar (POST)
curl -k -X POST "https://localhost:5001/api/products" -H "Content-Type: application/json" -d '{"name":"Produto A","description":"Descrição","price":10.5,"quantity":100}'

Curl - atualizar completamente (PUT)
curl -k -X PUT "https://localhost:5001/api/products/1" -H "Content-Type: application/json" -d '{"name":"Produto A","description":"Atualizado","price":12.0,"quantity":90}'

Curl - atualização parcial (PATCH)
curl -k -X PATCH "https://localhost:5001/api/products/1" -H "Content-Type: application/json" -d '{"price":11.0}'

Curl - deletar
curl -k -X DELETE "https://localhost:5001/api/products/1"

HTTPie (alternativa)
http --verify=no GET https://localhost:5001/api/products
http --verify=no POST https://localhost:5001/api/products name="Produto A" description="Descrição" price:=10.5 quantity:=100

Postman
- Importe as requests acima no Postman usando o método e o body JSON (raw -> application/json).
- Para o ambiente local, permita certificados autoassinados ou use HTTP se configurado.

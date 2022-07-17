Criando uma API com ASP.Net Core 2.2 EFCore e SQLite 

Instalação dos pacotes:
**template webapi ja possui EntityFrameworkCore dentro de "Microsoft.AspNetCore.App"

dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 2.2
dotnet add package Microsoft.EntityFrameworkCore.Sqlite.Design --version 2.0.0-preview1-final
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 2.2.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 2.2.6
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 2.2

Banco de dados e a classe de contexto:

dotnet ef dbcontext scaffold "Data Source=PizzaStore.db" Microsoft.EntityFrameworkCore.Sqlite -o Data -f -c PizzaStoreContext 

Referência à entidade:

public DbSet＜Cliente＞ Clientes { get; set; }

Migração e atualização do banco de dados:

dotnet ef migrations add FirstMigration
dotnet ef database update

Novo controller:


dotnet-aspnet-codegenerator -p "PizzaStore.csproj" controller -name ClienteController -api -m PizzaStore.Models.Cliente -dc PizzaStoreContext -outDir Controllers -namespace PizzaStore.Controllers

* Se o comando acima falhar, instale o geradore de código globalmente com o comando:

dotnet tool install --global dotnet-aspnet-codegenerator --version 2.2.4

Contexto no startup: ConfigureServices

services.AddDbContext＜Models.PizzaStoreContext(options => options.UseSqlite("Data Source=PizzaStore.db"));
services.AddDbContext<Data.PizzaStoreContext>(options => options.UseSqlite("Data Source=PizzaStore.db"));


Requisição no postman:
{
 "Nome":"Fernando",
 "Telefone":"(11)5464654654",
 "Email":"contato@fernandovezzali.com"
}
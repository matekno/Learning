# Swagger

Para agregar un swagger, además de obviamente instalar desde NuGet `Swagger` y `Swashbuckle`, tenemos que hacer lo siguiente:

```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 

var app = builder.Build();
app.UseSwagger(); 
app.UseSwaggerUI(); // si queremos UI (probablemente)
```
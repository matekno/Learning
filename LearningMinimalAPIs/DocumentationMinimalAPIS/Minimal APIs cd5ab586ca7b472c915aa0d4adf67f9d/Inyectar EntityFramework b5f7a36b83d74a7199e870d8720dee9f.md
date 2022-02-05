# Inyectar EntityFramework

En el programa, cuando armamos al builder, podemos hacer lo siguiente:

```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CRIPTOSContext>(); // esto es inyeccion de dependencias. Inyectamos el contexto de la base de datos, y asi no tenemos que usar mas el using
var app = builder.Build();

app.MapGet("/tokensInjected", async (CRIPTOSContext context) =>
    await context.Tokens.ToListAsync()
);
```
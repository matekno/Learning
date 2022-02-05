# Recibir parámetros por GET

Para recibir parámetros, tenemos que poner en la string del endpoint, entre llaves, la variable que vamos a recibir. Luego en el paréntesis de la función, especificar su tipo de dato:

```csharp
app.MapGet("/token/{id}", async (int id, CRIPTOSContext context) =>
{
    var token = await context.Tokens.FindAsync(id);
    return token != null ? Results.Ok(token) : Results.NotFound(); // IF TERNARIO: Si el token no es null, devolve Ok. Sino, devolve un NotFound
});
```

Lo que hace este método es buscar un token por ID. Si lo encuentra, devuelve el token correspondiente y un código 200 de Ok. En cambio, si no lo encuentra, devuelve un 404.
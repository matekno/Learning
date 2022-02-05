# Uso de funciones y clases

(si bien esto es más de C#, es algo especialmente importante en este caso, y ya se que el nombre de este notion es muy malo)

Algo que es completamente válido es lo siguiente:

```csharp
var temp = () =>
{
    return "hola";
};
app.MapGet("/saludo", temp);
```

Y algo que es un poco más útil, es lo siguiente:

```csharp
public class Temp
{
    public string ProbandoAndo()
    {
        return "holawas";
    }

}

Temp tmp = new Temp();
app.MapGet("/pruebaConObjetos", () => tmp.ProbandoAndo());
```

Nos ayuda a ser más organizado, y separar en clases nuestro código cuando tenemos muchas funciones, o muchos endpoints.
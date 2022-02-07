# La solución: Invertir las dependencias

Invertir las dependencias es bastante sencillo.

Para empezar, hacemos una interfaz, que, obligue a implementar ciertos métodos que usan la misma dependencia.

Siguiendo con el ejemplo de `InfoByFile` e `InfoByRequest`, ambos tenían un método `Get`  que traía la información, ya sea de un archivo, o de un endpoint.

Entonces, implementamos la siguiente interfaz en ambas clases:

```csharp
public interface IInfo
{
    public Task<IEnumerable<Post>> Get();
}
```

Después, en las clases que hacemos uso de `InfoByFile` o de `InfoByRequest`, en su lugar, hacemos lo siguiente:

```csharp
public class MonitorGood
{
    private string _origin;
    private IInfo _info; // 1
    
    public MonitorGood(string origin, IInfo info) //2
    {
        _origin = origin;
        _info = info; // 3
    }

    public async Task Show()
    {
        var posts = await _info.Get(); // 4 
        foreach (var post in posts)
        {
            Console.WriteLine(post.Title);     
        }
    }
}
```

1. Creamos un atributo o campo de `IInfo`, que es la interfaz, por lo que no nos va a importar de qué clase venga, solamente que implemente `IInfo`.
2. En el constructor parametrizado, recibimos un objeto de tipo `IInfo`.
3. Igualamos al `IInfo` del constructor con el local.
4. Ahora podemos hacer esto, porque todos los `_info` tienen seguro un método `Get`.

Y después en el programa, para ejecutar, hacemos lo siguiente:

```csharp
IInfo info = new InfoByRequest(origin); // 1
var monitorGood = new MonitorGood(origin, info); // 2
await monitorGood.Show();

var fileDbGood = new FileDBGood(dbPath, origin, info);
await fileDbGood.Save();

```

1. Instanciamos como `IInfo` a, ya sea `InfoByRequest` o a `InfoByFile`. Lo cambiamos según el requerimiento.
2. Mandamos a `info` como parámetro.
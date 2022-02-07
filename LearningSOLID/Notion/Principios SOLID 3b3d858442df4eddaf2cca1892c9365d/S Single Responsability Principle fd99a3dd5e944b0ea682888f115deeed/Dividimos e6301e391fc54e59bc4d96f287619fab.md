# Dividimos

Viene de [Caso en MVC](Caso%20en%20MVC%207a5510d8667f464e934b15deb0dd2976.md) 

Entonces, lo que podemos hacer para que el `controller` no tenga ninguna responsabilidad sobre las cervezas, podemos crear las siguientes clases:

- `BeerViewModel.cs`: si bien la clase ya estaba creada, la vuelvo a mencionar porque es importante, y solo tiene una responsabilidad, que es almacenar la información básica de la cerveza.
- `BeerDB.cs` que tiene la única responsabilidad de almacenar en la base de datos toda la información. Si necesitaramos, por ejemplo, hacer un CRUD, deberíamos abstraerla un poco más.
- `Log.cs` que tiene la única responsabilidad de guardar “cosas” en un archivo de logs. Esta pensada para que sea reutilizada, y no está atada a `Beer`
- `BeerService.cs` que, para terminar, es la que tiene la responsabilidad de agrupar a todos las demás clases, para así, crear la cerveza con todo lo que ella requiera.
    
    ```csharp
    public class BeerService
    {
        // Responsabilidad: Ejecutar la mecanica de las cervezas.
        public void Create(BeerViewModel beer)
        {
            var BeerDB = new BeerDB(); // usamos las clases ya creadas
            var Log = new Log(); 
            
            BeerDB.Save(beer);
            Log.Save($"Se guardo la cerveza {beer.Name}");
    }
    ```
    

Después, en el `controller`, solo basta con crear un `BeerService`, y pedirle que cree una cerveza:

```csharp
public IActionResult Add(BeerViewModel beer)
    {
        if (!ModelState.IsValid) // si el viewmodel es valido
        {
            return View(beer); 
        }

        var BeerService = new BeerService();
        BeerService.Create(beer);
        
				return Ok();
    }
```

 

Esto es muy útil, porque por ejemplo, si queremos que en el Log en lugar de que se guarde `$"Se guardo la cerveza {beer.Name}"` podemos crear un método en `BeerViewModel` de este estilo:

```csharp
public string BeerInfo() => $"Nombre: {this.Name}, Marca: {this.Brand}";
```

Y reemplazar el guardado en el Log por algo como:

```csharp
Log.Save(beer.BeerInfo());
```

Y no tocamos el controller, ni la clase de la base de datos, sino que para un cambio específico en el requerimiento, pudimos aplicar una solución de forma limpia y mucho más fácil.
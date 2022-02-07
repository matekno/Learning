# Divide and conquer

Al código anterior, como dijimos antes, lo podemos dividir en tres clases.

<aside>
💡 Por ejemplo, si quisieramos cambiar el lugar a donde se envía la cerveza, es tan fácil como cambiar la clase `BeerRequest` mientras que no tocamos a las demás.

</aside>

Las clases serían:

Una que sirva para guardar la información de la cerveza y sus atributos:

```csharp
public class Beer
 {
     // Responsabilidad 1: Guardar la informacion
     public string Name { get; set; }
     public string Brand { get; set; }
 
     public Beer(string name, string brand)
     {
         this.Name = name;
         this.Brand = brand;
     }
 }
```

Otra para almacenar la información de la cerveza en una base de datos:

```csharp
public class BeerDB
{
    // Responsabilidad 2: Guardar la cerveza
    private Beer _beer; 
    public BeerDB(Beer beer)
    {
        _beer = beer; // para poder sacar la info de la cerveza, necesitamos instanciar una local
    }
    
    public void Save()
    {
        // aca subiriamos la cerveza a la bdd
        Console.WriteLine($"Guardado {_beer.Name} y {_beer.Brand}");
    }
}
```

Una última para enviar la información a algún lado

```csharp
public class BeerRequest
{
    // Responsabilidad 3: Enviar la cerveza
    private Beer _beer;
    public BeerRequest(Beer beer)
    {
        _beer = beer;
    }
    
    public void Send()
    {
        // aca enviariamos la cerveza a algun lado
        Console.WriteLine($"Enviado {Name} y {Brand}");
    }
}
```
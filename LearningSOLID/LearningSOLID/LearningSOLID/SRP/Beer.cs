namespace LearningSOLID.SRP;

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
        Console.WriteLine($"Enviado {_beer.Name} y {_beer.Brand}");
    }
}
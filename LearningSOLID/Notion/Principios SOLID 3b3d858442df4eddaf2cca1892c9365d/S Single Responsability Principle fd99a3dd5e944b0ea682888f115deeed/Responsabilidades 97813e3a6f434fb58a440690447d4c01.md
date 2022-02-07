# Responsabilidades

La siguiente clase `Beer` tiene, si nos fijamos, tres responsabilidades que estan detalladas en los comentarios:

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
 
     // Responsabilidad 2: Guardar la cerveza
     public void Save()
     {
         // aca subiriamos la cerveza a la bdd
         Console.WriteLine($"Guardado {Name} y {Brand}");
     }
     // Responsabilidad 3: Enviar la cerveza
     public void Send()
     {
         // aca enviariamos la cerveza a algun lado
         Console.WriteLine($"Enviado {Name} y {Brand}");
     }
 }
```

Lo que el principio de responsabilidad única nos pide es que dividamos esta clase en tres, una con cada responsabilidad

![Untitled](Responsabilidades%2097813e3a6f434fb58a440690447d4c01/Untitled.png)
# Aprovechando el Select

Dado el siguiente ejemplo:

```csharp
List<Persona> personas = new List<Persona>()
{
    new Persona() {Edad = 40, Nombre = "Mati"},
    new Persona() {Edad = 17, Nombre = "Jose"},
    new Persona() {Edad = 32, Nombre = "Ariel"},
    new Persona() {Edad = 10, Nombre = "Nico"},
    new Persona() {Edad = 24, Nombre = "Juan"}
};

public class Persona
{
    public int Edad { get; set; }
    public string Nombre { get; set; }
}
```

Podemos seleccionar solamente un atributo de esa lista, por ejemplo el nombre de las personas

```csharp
// devolver solamente un atributo de los objetos
List<string> lstOrdenadosSoloNombres = (from persona in personas
                                        orderby persona.Nombre
                                        select persona.Nombre).ToList();
```

Además, podemos concatenar elementos en el `select` (siempre y cuando sean del mismo tipo)

```csharp
// se puede guardar en la lista resultante un valor generado:
List<string> lstNombresConEdades = (from persona in personas
                                    orderby persona.Nombre
                                    select (persona.Edad + "    " + persona.Nombre)).ToList();
```
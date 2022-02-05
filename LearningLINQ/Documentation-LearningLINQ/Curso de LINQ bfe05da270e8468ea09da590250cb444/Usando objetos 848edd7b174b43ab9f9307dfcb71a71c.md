# Usando objetos

Dada la siguiente clase y lista:

```csharp
public class Complejo
{
    public int numero { get; set; }
    public string cadena { get; set; }

    public Complejo(int numero, string cadena)
    {
        this.numero = numero;
        this.cadena = cadena;
    }

    public string Imprimir()
    {
        return numero + "   " + cadena;
    }
}

Complejo[] lst3 =
{
    new Complejo(1, "mati"),
    new Complejo(2, "jose"),
    new Complejo(9, "ariel"),
    new Complejo(55, "nico"),
    new Complejo(8, "mati")
};
```

Para traer un solo objeto de la lista:

```csharp
// para traer un solo objeto:
var oJose = (from name in lst3 // usamos parentesis porque despues vamos a usar otro metodo que modifica a toda la sentencia linq.
             where name.cadena == "jose" // podemos, obviamente, usar atributos de objetos
             select name).FirstOrDefault(); // el metodo FirstOrDefault nos trae solo el primer elemento de la lista que coincide. Si no hay ninguno, no trae nada.
Console.Write(oJose.Imprimir());
```

Para traer una lista con mas de un objeto

```csharp
// para traer una lista modificada. Esto nos devuelve un objeto de tipo linq. Si queremos, podemos agragar el metodo ToList para que lo convierta a lista:
var lst3Ordered = from comp in lst3
                  orderby comp.numero
                  select comp;

// otro ejemplo 
var lst3mod = (from comp in lst3
               where comp.cadena == "mati"
               select comp).ToList();
```

<aside>
💡 OJO: Si no ponemos el método `ToList()` al final, y esperamos más de un objeto, vamos a recibir un objeto raro de tipo LINQ

</aside>
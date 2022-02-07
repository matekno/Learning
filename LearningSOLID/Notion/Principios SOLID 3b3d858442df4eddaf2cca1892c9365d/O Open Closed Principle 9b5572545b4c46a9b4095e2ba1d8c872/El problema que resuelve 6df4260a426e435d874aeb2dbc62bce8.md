# El problema que resuelve

Imaginemos la siguiente clase

```csharp
public class Drink
{
    public string Name { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
}
```

Y, respetando los demás principios, hacemos una clase `Invoice` que nos da el total de las bebidas con sus impuestos.

```csharp
public class Invoice
{
    public decimal GetTotal(IEnumerable<Drink> lstDrinks)
    {
        decimal total = 0;
        foreach (var drink in lstDrinks)
        {
            if (drink.Type == "Agua")
            {
                total += drink.Price;
            } 
            else if (drink.Type == "Gaseosa")
            {
                total += drink.Price  * 0.33m;
            }
            else if (drink.Type == "Alcoholica")
            {
                total += drink.Price  * 0.5m;
            }
        }
        return total;
    }
}
```

Si bien cumple con el principio SRP tiene un problema:

Si quisiéramos agregar un nuevo tipo de bebida, con un tipo de impuesto distinto, deberíamos cambiar todo esto, y eso es un problema, porque códigos grandes, quilombo cuando esta en producción, en fín, no es escalable.
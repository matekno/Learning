# Implementar interfaces

Siguiendo con el ejemplo anterior, lo que podemos hacer es crear una interfaz, y que todas las bebidas que creemos la implementen 

```csharp
public interface IDrink
{
    string Name { get; set; }
    decimal Price { get; set; }
    decimal Tax { get; set; }
    decimal GetFinalPrice();
}
```

Y por ejemplo, podemos crear infinitas bebidas, sin importar su tipo. Acá creamos Agua:

```csharp
public class Water : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Tax { get; set; }
    public decimal GetFinalPrice() => Price * Tax;
}
```

Acá creamos un whiskey:

```csharp
public class Whiskey : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Tax { get; set; }
    public decimal Promo { get; set; }
    public decimal GetFinalPrice() => Price * Tax;
}
```

Y ahora, en la clase Invoice:

```csharp
public class Invoice
{
    public decimal GetTotal(IEnumerable<IDrink> lstDrinks)
    {
        decimal total = 0;
        foreach (var drink in lstDrinks)
        {
            total += drink.GetFinalPrice(); // No importa como cada bebida implemente el metodo, sino que lo que importa es que este. por eso usamos una interfaz.
        }
        return total;
    }
}
```
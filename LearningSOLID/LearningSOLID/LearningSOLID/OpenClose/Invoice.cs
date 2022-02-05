namespace LearningSOLID.SRP;

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
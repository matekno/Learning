namespace LearningSOLID.InterfaceSegregation.Utils;

public class SaleService : IBasicActions<Sale>
{
    public Sale Get(int id)
    {
        Console.WriteLine("Obtenemos la venta");
        return new Sale();
    }

    public List<Sale> GetList()
    {
        Console.WriteLine("Obtenemos la lista de ventas");
        return new List<Sale>();
    }

    public void Add(Sale entity)
    {
        Console.WriteLine("Agregamos una venta");
    }
}
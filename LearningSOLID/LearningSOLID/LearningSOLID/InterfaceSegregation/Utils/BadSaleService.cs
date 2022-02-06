namespace LearningSOLID.InterfaceSegregation.Utils;


// No queremos que se pueda ni eliminar ni modificar una venta
// Pero la interfaz nos obliga a implementar esos metodos
// Por eso podemos segregar las interfaces y abstraerlas un poco mas.

public class BadSaleService : IBadCRUD<Sale>
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
    
    public void Update(Sale entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Sale entity)
    {
        throw new NotImplementedException();
    }
}
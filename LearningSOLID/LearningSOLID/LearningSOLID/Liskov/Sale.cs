namespace LearningSOLID.Liskov;

public class Sale : AbstractSale
{
    public override void Generate()
    {
        Console.WriteLine("se genera la venta"); // simulamos
    }

    public override void CalculateTax()
    {
        Console.WriteLine("impuestos calculados"); // simulamos
    }
}
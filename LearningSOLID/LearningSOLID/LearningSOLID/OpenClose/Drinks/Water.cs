namespace LearningSOLID.SRP.Drinks;


public class Water : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Tax { get; set; }
    
    public decimal GetFinalPrice() => Price * Tax;
}
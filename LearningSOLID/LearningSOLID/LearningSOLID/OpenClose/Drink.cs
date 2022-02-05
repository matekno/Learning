namespace LearningSOLID.SRP;

public interface IDrink
{
    string Name { get; set; }
    decimal Price { get; set; }
    decimal Tax { get; set; }
    
    decimal GetFinalPrice();

}
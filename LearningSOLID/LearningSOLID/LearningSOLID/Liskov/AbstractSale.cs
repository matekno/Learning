namespace LearningSOLID.Liskov;

public abstract class AbstractSale //T
{
    decimal amount;
    private string customer;
    private decimal takes;

    public abstract void Generate();
    public abstract void CalculateTax();

}
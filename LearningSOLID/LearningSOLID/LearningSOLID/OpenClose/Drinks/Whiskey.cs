namespace LearningSOLID.SRP.Drinks;

public class Whiskey : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Tax { get; set; }
    public decimal Promo { get; set; } // por ejemplo, podemos hacer que los whiskeys tengan promo solamente cambiando este metodo 
                                       // cuando cambia el requerimiento, por ejemplo, los whiskeys ya no tienen promo, solo venimos a esta clase y lo cambiamos.
    public decimal GetFinalPrice() => (Price * Tax) - Promo;
}
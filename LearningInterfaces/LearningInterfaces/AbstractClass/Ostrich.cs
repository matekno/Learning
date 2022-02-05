namespace LearningInterfaces.AbstractClass;

// un avestruz es un ave, que no puede volar pero si correr
// siendo un ave esta obligada a enviar en el constructor sus alas, y con IRun esta obligada a implementar un metodo Run()
public class Ostrich : Bird, IRun
{
    public int LegsSize { get; set; }
    public Ostrich(int wingsSize) : base(wingsSize) // constructor con herencia!
    {
        
    }

    public void Run()
    {
        Console.WriteLine("el avestruz esta corriendo");
    }
}
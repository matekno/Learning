namespace LearningInterfaces.AbstractClass;

// todas las aves tienen alas
public abstract class Bird
{
    public int WingsSize { get; set; }

    public Bird(int wingsSize)
    {
        this.WingsSize = wingsSize;
    }
}
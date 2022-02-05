namespace LearningInterfaces.AbstractClass;

// si bien todas las aves tienen alas, no todas pueden correr, pero las que pueden, tienen piernas
public interface IRun
{
   int LegsSize { get; set; }
   void Run();
}
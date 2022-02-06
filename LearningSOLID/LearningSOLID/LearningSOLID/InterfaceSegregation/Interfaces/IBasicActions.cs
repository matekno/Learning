namespace LearningSOLID.InterfaceSegregation;

public interface IBasicActions <T>
{
    public T Get(int id);
    public List<T> GetList();
    public void Add(T entity);
}
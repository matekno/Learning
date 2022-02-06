namespace LearningSOLID.InterfaceSegregation;

public interface IBadCRUD<T>
{
    public T Get(int id);
    public List<T> GetList();
    public void Add(T entity);
    public void Update(T entity);
    public void Delete(T entity);
}
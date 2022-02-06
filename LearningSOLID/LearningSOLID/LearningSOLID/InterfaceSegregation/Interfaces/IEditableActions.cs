namespace LearningSOLID.InterfaceSegregation;

public interface IEditableActions <T>
{
    public void Update(T entity);
    public void Delete(T entity);
}
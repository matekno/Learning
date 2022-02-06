namespace LearningSOLID.InterfaceSegregation.Utils;


// Ahora implementamos dos interfaces, una basica y otra editable.

public class RefactoredUserService : IBasicActions <User>, IEditableActions<User>
{
    public User Get(int id)
    {
        Console.WriteLine("Obtenemos el usuario");
        return new User();
    }

    public List<User> GetList()
    {
        Console.WriteLine("Obtenemos la lista de usuarios");
        return new List<User>();
    }

    public void Add(User entity)
    {
        Console.WriteLine("agregamos el usuario");
    }

    public void Update(User entity)
    {
        Console.WriteLine("actualizamos el usuario");
    }

    public void Delete(User entity)
    {
        Console.WriteLine("eliminamos el usuario");
    }
}
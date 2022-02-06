namespace LearningSOLID.InterfaceSegregation.Utils;


// Justo en este caso nos sirve que esten todos los metodos del crud, porque el requerimiento asi nos pide
// Pero es posible, como en el caso de SaleService, que no ncecesitemos implementar all the methods
public class UserService : IBadCRUD<User>
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
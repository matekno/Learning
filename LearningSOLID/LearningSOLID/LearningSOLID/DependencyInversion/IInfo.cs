namespace LearningSOLID.DependencyInversion;

// implementamos una interfaz en cada clase que tengamos este metodo
// en nuestro caso, InfoByFile e InfoByRequest
public interface IInfo
{
    public Task<IEnumerable<Post>> Get();
}
namespace LearningSOLID.DependencyInversion;

public class MonitorGood
{
    private string _origin;
    private IInfo _info; // inyectamos la dependencia!
    

    public MonitorGood(string origin, IInfo info)
    {
        _origin = origin;
        _info = info;
    }

    public async Task Show()
    {
        var posts = await _info.Get(); // ahora podemos hacer esto, porque todos los info tienen seguro un metodo Get.
        foreach (var post in posts)
        {
            Console.WriteLine(post.Title);     
        }
    }
}
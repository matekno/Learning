namespace LearningSOLID.DependencyInversion;

public class Monitor
{
    private string _origin;

    public Monitor(string origin)
    {
        _origin = origin;
    }

    public async Task Show()
    {
        InfoByFile info = new InfoByFile(_origin);
        var posts = await info.Get();
        foreach (var post in posts)
        {
            Console.WriteLine(post.Title);     
        }
    }
}
namespace LearningSOLID.DependencyInversion;
using System.Text.Json;

public class InfoByFile : IInfo
{
    private string _path;
    public InfoByFile(string path)
    {
        _path = path;
    }

    public async Task<IEnumerable<Post>> Get()
    {
        var contentStream = new FileStream(_path, FileMode.Open, FileAccess.Read);
        IEnumerable<Post> posts =
            await JsonSerializer.DeserializeAsync<List<Post>>(contentStream);
        return posts;
    }
}
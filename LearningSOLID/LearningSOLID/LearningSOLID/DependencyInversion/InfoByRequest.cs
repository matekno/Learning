using System.Text.Json;

namespace LearningSOLID.DependencyInversion;

public class InfoByRequest : IInfo
{
    private string _url;

    public InfoByRequest(string url)
    {
        _url = url;
    }

    public async Task<IEnumerable<Post>> Get()
    {
        HttpClient httpClient = new HttpClient();
        var response = await httpClient.GetAsync(_url);
        var stream = await response.Content.ReadAsStreamAsync();
        List<Post> posts = await JsonSerializer.DeserializeAsync<List<Post>>(stream);
        return posts;
    }
}
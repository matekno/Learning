using System.Text.Json;

namespace LearningSOLID.DependencyInversion;
class FileDB
{
    private string _path;
    private string _origin;

    public FileDB(string path, string origin)
    {
        _path = path;
        _origin = origin;
    }

    public async Task Save()
    {
        // una funcion que simula el guardado "en una base de datos"
        InfoByFile info = new InfoByFile(_origin); // genera una fuerta dependencia de InfoByFile.
        var posts = await info.Get();
        string json = JsonSerializer.Serialize(posts);
        await File.WriteAllTextAsync(_path, json);
    }
}
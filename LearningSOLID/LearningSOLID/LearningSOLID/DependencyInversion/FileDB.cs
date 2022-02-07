using System.Text.Json;

namespace LearningSOLID.DependencyInversion;
class FileDBGood
{
    private string _path;
    private string _origin;
    private IInfo _info;

    public FileDBGood(string path, string origin, IInfo info)
    {
        _path = path;
        _origin = origin;
        _info = info;
    }

    public async Task Save()
    {
        // InfoByFile info = new InfoByFile(_origin); // genera una fuerta dependencia de InfoByFile.
        var posts = await _info.Get(); // en lugar de instanciarlo y generar dependencia, usamos la dependencia inyectada
        string json = JsonSerializer.Serialize(posts);
        await File.WriteAllTextAsync(_path, json);
    }
}
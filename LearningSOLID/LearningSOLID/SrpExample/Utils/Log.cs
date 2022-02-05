namespace SrpExample.Utils;
using System.IO;

public class Log
{
    // Responsabilidad: guarda en un archivo especifico un log.
    private readonly string _fileName = "log.txt";
    public async void Save(string content)
    {
        await File.WriteAllTextAsync(_fileName, content);
    }
}
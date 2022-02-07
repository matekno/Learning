# Un mejor ejemplo

Hacemos un método que genere un número random. Esto es muy útil porque ahorramos tiempo, y mientras se genera el numero random podemos estar haciendo otra cosa:

```csharp
async Task<int> RandomNumAsync()
{
    var task = new Task<int>((() => new Random().Next(1000)));
    task.Start();
    int result = await task;
    return result;
}
```

Luego, cuando lo llamamos, hacemos algo así:

```csharp
int resultRnd = await RandomNumAsync();
Console.WriteLine(resultRnd);
```

Y listo!
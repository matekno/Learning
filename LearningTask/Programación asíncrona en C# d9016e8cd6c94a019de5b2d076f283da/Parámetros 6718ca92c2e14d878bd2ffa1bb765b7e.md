# Parámetros

A diferencia de otros métodos donde usamos expresiones lambda, Task no necesita que le mandemos parámetros; automáticamente usa los que recibe de afuera.

NO HAY que poner nada en los paréntesis esos.

```csharp
async Task<int> SquareNum(int num)
{
		// si pusieramos un int num aca, tambien alcanza
    var task = new Task<int>(() => num * num);
    task.Start();
    int result = await task;
    return result;
}
```
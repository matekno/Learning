# Funciones asíncronas

Siempre que usemos el `async` estamos usando un Task.

Entonces, si queremos hacer una función asíncrona que devuelva void, tenemos que escribirla así:

```csharp
public async Task myFunction()
{

}
```

Y si queremos hacer una función que devuelva algo, ponemos lo que querramos que devuelva en los generics:

```csharp
public async Task<int> myFunction()
{
	int dummy;
	// code
	return dummy;
}
```
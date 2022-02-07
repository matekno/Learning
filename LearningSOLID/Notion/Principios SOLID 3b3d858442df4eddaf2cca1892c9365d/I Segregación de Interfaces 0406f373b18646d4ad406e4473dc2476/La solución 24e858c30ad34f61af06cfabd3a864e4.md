# La solución

La solución es abstraer las interfaces, o segregarlas.

Creando así dos interfaces:

```csharp
public interface **IBasicActions** <T>
{
    public T Get(int id);
    public void Add(T entity);
}
```

```csharp
public interface **IEditableActions** <T>
{
    public void Update(T entity);
    public void Delete(T entity);
}
```

Entonces, ahora, como todas las entidades van a usar los `BasicActions`, podemos usar esa interfaz para todos los que necesitemos, y `IEditableActions` solamente para los que queramos que se puedan editar y borrar

Esto no significa hacer una interfaz por cada método, pero sí tiene que ver con aislar lo máximo posible las interfaces de forma lógica y racional según el proyecto, para que así podamos escalar el proyecto mucho más.
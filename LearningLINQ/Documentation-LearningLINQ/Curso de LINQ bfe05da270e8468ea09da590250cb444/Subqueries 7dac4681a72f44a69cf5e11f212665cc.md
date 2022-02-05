# Subqueries

Al igual que en SQL, podemos usar subqueries.

Las subqueries, son, básicamente, una query adentro de otra.

Mirar el siguiente ejemplo:

```csharp
List<string> nombresDePersonas = (from a in 
                                      (from persona in personas
                                       select persona)
                                      .Union(from persona in personas2
                                             select persona)
                                  orderby a.Nombre
                                  select a.Nombre)
															   .ToList();
```

Lo que hacemos es:

- Con una variable llamada a, itera sobre una query en sí mismo. Podríamos poner, por ejemplo, dentro de ella, un `Take`, un `OrderBy`, un Su`m`, lo que haga falta.
- Luego unimos con la otra lista de personas
- Ordenamos la colección resultante
- Guardamos en la colección resultante solamente los nombres
- Lo pasamos a lista

En este caso, es complicarse al pedo, porque podríamos hacer:

```csharp
// esto es lo mismo pero un poco mas simplificado
List<string> nombresDePersonas2 = (from alias in 
                                       personas.Union(personas2)
                                   orderby alias.Nombre
                                   select alias.Nombre).ToList();
```
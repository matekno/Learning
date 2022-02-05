# Métodos lambda en LINQ

La mayoría de las sentencias LINQ se pueden usar también como métodos:

```csharp
// La mayoria de sentencias Linq tambien estan disponibles como metodos lambda
List<string> listaCompletaPersonas = personas // es lo mismo que poner: (from p in personas select p)
                                     .Union(personas2) // como en este momento estamos la lista resultante es de tipo Persona, podemos concatenar mas PersonaS
                                     .OrderBy(p => p.Nombre)
                                     .Select(p => p.Nombre) // el select lo podemos usar con un metodo lambda. Lo que hace este, es seleccionar para la lista resultante solamente los nombres de las personas
                                     .ToList();
```

Otro ejemplo, recordando que en todos los métodos que no son lambda, podemos usar sentencias LINQ:

```csharp
List<string> listaCompletaPersonas2 = personas
                                      .Union(from persona in personas2
                                             select persona) // en todos los metodos que no son lambda, podemos usar sentencias LINQ
                                      .OrderBy(p => p.Nombre)
                                      .Select(p => p.Nombre)
                                      .ToList();
```
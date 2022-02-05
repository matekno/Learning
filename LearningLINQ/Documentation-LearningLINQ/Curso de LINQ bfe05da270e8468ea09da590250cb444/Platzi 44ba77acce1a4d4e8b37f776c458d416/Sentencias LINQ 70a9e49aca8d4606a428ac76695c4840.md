# Sentencias LINQ

## Select

Nos permite hacer una selección sobre una colección de datos, ya sea seleccionándolos todos, solo una parte o transformándolos:

```csharp
var nombresAlumnos = alumnos.Select(x => x.Nombre).ToList();
```

## Where

Nos permite seleccionar una colección a partir de otra con los objetos que cumplan las condiciones especificadas:

```csharp
var alumnosAprobados = alumnos.Where(x => x.Nota >= 5).ToList();
```

Lo que hace esto, es crear una lista llamada `alumnosAprobados` basada en los alumnos que tienen una nota mayor a 5.

Ojo no confundir el `=>` de la arrow function con el `>=` de la condición del `where`

## First / Last

Nos permite obtener el primer / último objeto de la colección:

```csharp
var primero = alumnos.First();
var ultimo = alumnos.Last();
```

## OrderBy

`OrderBy` nos permite ordenar una colección en base a un criterio que pongamos en la función lambda. `OrderByDescending` hace lo mismo pero lo ordena al revés:

```csharp
var ordenadoMenorAMayor = alumnos.OrderBy(x => x.Nota).ToList();
var ordenadoMayorAMenos = alumnos.OrderByDescending(x => x.Nota).ToList();
```

## All / Any

Nos permiten saber si todos o alguno de los valores, respectivamente, cumplen con el criterio que le indiquemos:

```csharp
var todosAprobados = alumnos.All(x => x.Nota >= 5);
var algunAprobado = alumnos.Any(x => x.Nota >= 5);
```
# Sentencias LINQ numéricas

## Sum

Nos permite sumar todos los números de una colección:

```csharp
var sumaNotas = alumnos.Sum(x => x.Nota);
```

## Max / Min

Nos permite obtener el máximo y el mínimo de la colección:

```csharp
var notaMaxima = alumnos.Max(x => x.Nota);
var notaMinima = alumnos.Min(x => x.Nota);
```

## Average

Nos permite obtener un promedio numérico de los elementos de la colección:

```csharp
var media = alumnos.Average(x => x.Nota);
```
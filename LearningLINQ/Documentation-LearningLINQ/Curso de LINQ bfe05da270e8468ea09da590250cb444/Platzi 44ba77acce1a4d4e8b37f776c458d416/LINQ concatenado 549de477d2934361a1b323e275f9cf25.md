# LINQ concatenado

Una de las grandes funcionalidades de LINQ es que nos permite concatenar sentencias LINQ.

Para esto hay que aprender una sentencia más que es el `from` que, al igual que en SQL, nos permite especificar la ubicación de la colección a trabajar. Su sintaxis es la siguiente:

```csharp
var todosLosAlumnos = from alu in alumnos
											select alu;
```

## Ejemplo concatenación

```csharp
var resultado = from alumno in alumnos // vamos a recorrer a la lista de alumnos
                where alumno.Nota >= 5 // cuando la nota sea mayor a 5
                orderby alumno.Nota // ordena a los alumnos segun su nota
                select alumno; // arma la nueva lista de alumnos
```

Con un código así de sencillo, podemos sacar una lista de los alumnos con nota mayor a 5.
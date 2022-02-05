# Ejemplo de LINQ

LINQ es un lenguaje de programación creado por Microsoft que nos permite hacer “queries” dentro de C# o .net de manera declarativa:

```csharp
private IEnumerable<Alumno> CargarAlumnos()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            var listaAlumnos =  from n1 in nombre1
                    from n2 in nombre2
                    from a1 in apellido1
                    select new Alumno($"{n1} {n2} {a1}");

            return listaAlumnos;
            // throw new NotImplementedException();
        }
```

Lo que va a hacer este codigo es crear una lista de alumnos mezclando nombres de 3 arreglos distintos.

```csharp
var listaAlumnos =  from n1 in nombre1
                    from n2 in nombre2
                    from a1 in apellido1
                    select new Alumno($"{n1} {n2} {a1}");
```

La de arriba es la sentencia LINQ, que es muy similar a un SQL, pero medio raro.
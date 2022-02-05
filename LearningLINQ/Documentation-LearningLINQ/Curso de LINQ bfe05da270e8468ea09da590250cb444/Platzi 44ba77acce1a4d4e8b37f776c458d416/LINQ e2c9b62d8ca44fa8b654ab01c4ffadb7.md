# LINQ

[https://www.campusmvp.es/recursos/post/introduccion-rapida-a-linq-con-c-sharp.aspx](https://www.campusmvp.es/recursos/post/introduccion-rapida-a-linq-con-c-sharp.aspx)

## ¿Qué es LINQ?

<aside>
💡 LINQ (**L**anguage **In**tegrated **Q**uery) es un conjunto de extensiones integradas en el lenguaje C#, que nos permite trabajar de manera cómoda y rápida con colecciones de datos, como si de una base de datos se tratase. Es decir, podemos llevar a cabo inserciones, selecciones y borrados, así como operaciones sobre sus elementos.

</aside>

Para usarla, tenemos que incluir al `namespace` de `System.LINQ`

Con LINQ, por ejemplo, podemos convertir esto:

```csharp
var valores = new List<int> {1,2,3,4,5,6,7,8,9};
var suma = 0;
foreach (var valor in valores)
{
    suma += valor;
}
```

En algo tan sencillo como esto:

```csharp
var valores = new List<int> {1,2,3,4,5,6,7,8,9};
var suma = valores.Sum();
```
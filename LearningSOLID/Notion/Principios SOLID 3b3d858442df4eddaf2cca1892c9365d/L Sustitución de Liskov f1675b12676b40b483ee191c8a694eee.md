# L: Sustitución de Liskov

[https://github.com/matekno/Learning/blob/master/LearningSOLID/LearningSOLID/LearningSOLID/Program.cs](https://github.com/matekno/Learning/blob/master/LearningSOLID/LearningSOLID/LearningSOLID/Program.cs)

[Learning/LearningSOLID/LearningSOLID/LearningSOLID/Liskov at liskov · matekno/Learning](https://github.com/matekno/Learning/tree/liskov/LearningSOLID/LearningSOLID/LearningSOLID/Liskov)

<aside>
💡 Una clase hija nunca debe alterar el funcionamiento de la clase padre. ~~También aplica a interfaces.~~

</aside>

Cada clase hija de otra clase, puede usarse como su padre. El corolario de esto es que una clase hija puede sustituir al padre.

No hay que confundir con segregación de interfaces.

Imaginemos las siguientes clases:

```csharp
public abstract class T
{
    public abstract string GetName();
}
```

```csharp
public class S : T
{
    public override string GetName() => "S";
}
```

Para que cumpla con el principio de Liskov, deberíamos (y podemos) hacer lo siguiente:

```csharp
T t = new S(); // cumple con el principio de sutitucion de liskov
```

Además, si agregáramos otra clase, llamada S2 que sea hija de T, podríamos hacer esto sin problema:

```csharp
T t = new S();
Console.WriteLine(t.GetName()); // out: S
t = new S2(); // como cumple con el principio de sutitucion de liskov, podemos hacer esto, ya que S2 es hija de T.
Console.WriteLine(t.GetName()); // out: S2
```
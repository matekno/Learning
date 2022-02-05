using LearningInterfaces.Interfaces;
using LearningInterfaces.Models;
using LearningInterfaces.AbstractClass;


#region interfaces-ej-con-bebidas

IBebida oBebidaC = new Cerveza();
// IBebidaAlcoholica oBebidaV = new VinoTinto();
IBebida oBebidaV = new VinoTinto();

var lst = new List<IBebida>(); // aunque son de distinta clase, nos deja hacer una lista de IBebida, porque ambas son bebida
lst.Add(oBebidaC);
lst.Add(oBebidaV);

Mostrar(lst);

void Mostrar(List<IBebida> list)
{
    foreach (var bebida in list)
    {
        Console.WriteLine(bebida.Mostrar()); // podemos estar seguros de que todas las bebidas tienen un metodo mostrar
    }
}

#endregion






var stop = 0;

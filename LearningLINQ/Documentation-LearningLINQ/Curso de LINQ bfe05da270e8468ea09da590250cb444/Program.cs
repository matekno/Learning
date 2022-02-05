using System.Linq;
using MoreLinq;
using System;
using System.ComponentModel.Design;
using System.IO.Compression;
using System.Text;
Console.WriteLine("Hello, World!");

int[] array = {1, 2, 5, 88, 9, 47, 5, 12, 600, 85};
Complejo[] lst3 =
{
    new Complejo(1, "mati"),
    new Complejo(2, "jose"),
    new Complejo(9, "ariel"),
    new Complejo(55, "nico"),
    new Complejo(8, "mati")
};
List<Persona> personas = new List<Persona>()
{
    new Persona() {Edad = 40, Nombre = "Mati"},
    new Persona() {Edad = 17, Nombre = "Jose"},
    new Persona() {Edad = 32, Nombre = "Ariel"},
    new Persona() {Edad = 10, Nombre = "Nico"},
    new Persona() {Edad = 24, Nombre = "Juan"}
};
List<string> lstSoloTexto = new List<string>()
{
    "32 - mati",
    "10 - nico",
    "8 - juan"
};
List<Persona> personas2 = new List<Persona>()
{
    new Persona() {Edad = 58, Nombre = "Anto"},
    new Persona() {Edad = 63, Nombre = "Renata"},
    new Persona() {Edad = 4, Nombre = "Caro"}
};


#region operaciones-basicas

// Ordenar los numeros de menor a mayor
IEnumerable<int> lst = from num in array // esto es como un foreach, en el from ponemos una variable que representa a cada elemento dentro de lo que este despues de in
                       orderby num // igual que el order by de SQL 
                       select num; // al final de cualquier linq, ponemos un select, que significa que guarde en la lista resultante el valor obtenido en la query
foreach (var num in lst)
{
    Console.WriteLine(num);
}


// Usar el where
IEnumerable<int> lst2 = from num in array
                        where num >= 10 || num == 2 // es lo mismo que hacer: where num is >= 10 or 2 
                        select num; // al final de cualquier linq, ponemos un select, que significa que guarde en la lista resultante el valor obtenido en la query

#endregion

#region usando-objetos-complejos

// para traer un solo objeto:
var oJose = (from name in lst3 // usamos parentesis porque despues vamos a usar otro metodo que modifica a toda la sentencia linq.
             where name.cadena == "jose" // podemos, obviamente, usar atributos de objetos
             select name).FirstOrDefault(); // el metodo FirstOrDefault nos trae solo el primer elemento de la lista que coincide. Si no hay ninguno, no trae nada.

Console.Write(oJose.Imprimir());


// para traer una lista modificada. Esto nos devuelve un objeto de tipo linq. Si queremos, podemos agragar el metodo ToList para que lo convierta a lista:
var lst3Ordered = from comp in lst3
                  orderby comp.numero
                  select comp;

// otro ejemplo 
var lst3mod = (from comp in lst3
               where comp.cadena == "mati"
               select comp).ToList();

#endregion

#region haciendo-uso-del-select

// devolver solamente un atributo de los objetos
List<string> lstOrdenadosSoloNombres = (from persona in personas
                                        orderby persona.Nombre
                                        select persona.Nombre).ToList();

// se puede guardar en la lista resultante un valor generado:
List<string> lstNombresConEdades = (from persona in personas
                                    orderby persona.Nombre
                                    select (persona.Edad + "    " + persona.Nombre)).ToList();

#endregion

#region metodos-skip-y-take

// usando el metodo Take, podemos guardar solamente los primeros elementos de la lista resultante (es como el TOP de SQL):
List<string> lstNombresConEdades2 = (from persona in personas
                                     orderby persona.Nombre
                                     select (persona.Nombre)).Take(2).ToList();

// podemos concatenar el metodo Take con el Skip, que saltea n posiciones para la lista resultante:
// IMPORTANTE: el metodo Skip siempre va antes que el Take (pensarlo dos segundos)
List<string> lstNombresConEdades3 = (from persona in personas
                                     orderby persona.Nombre
                                     select (persona.Nombre)).Skip(2).Take(2).ToList();

#endregion

#region usando-union

// IMPORTANTE: hay que tener muy en cuenta en que momento de la depuracion estamos para poder usar Union, porque nos podemos marear con el tipo de dato

// para concatenar listas
List<string> usandoUnion = (from persona in personas
                            orderby persona.Nombre
                            select (persona.Edad + " - " + persona.Nombre)).Union(lstSoloTexto).ToList();

// usar el metodo orderBy para ordenar la lista resultante
List<string> usandoUnionOrdenado = (from persona in personas
                                    select (persona.Edad + " - " + persona.Nombre))
                                   .Union(lstSoloTexto)
                                   . // IMPORTANTE: aca podemos usar union, porque en este momento, estamos en una lista de strings, y lstSoloTexto es de tipo string
                                   OrderBy(p => p). // por cada p, ordena en p. es medio choto el ordenamiento porque estamos explorando strings y no Personas 
                                   ToList();

#endregion

#region metodos-lambda-en-linq

// La mayoria de sentencias Linq tambien estan disponibles como metodos lambda
List<string> listaCompletaPersonas = personas // es lo mismo que poner: (from p in personas select p)
                                     .Union(personas2) // como en este momento estamos la lista resultante es de tipo Persona, podemos concatenar mas PersonaS
                                     .OrderBy(p => p.Nombre)
                                     .Select(p => p.Nombre) // el select lo podemos usar con un metodo lambda. Lo que hace este, es seleccionar para la lista resultante solamente los nombres de las personas
                                     .ToList();

// La mayoria de sentencias Linq tambien estan disponibles como metodos lambda
List<string> listaCompletaPersonas2 = personas
                                      .Union(from persona in personas2
                                             select persona) // en todos los metodos que no son lambda, podemos usar sentencias LINQ
                                      .OrderBy(p => p.Nombre)
                                      .Select(p => p.Nombre)
                                      .ToList();

#endregion

#region subqueries-en-linq

// En LINQ podemos hacer subqueries.
// En este caso, lo que hacemos es que en el from-in, busque sobre otra query
// Es muy util, sirve como un join a veces
List<string> nombresDePersonas = (from alias in 
                                      (from persona in personas
                                       select persona)
                                      .Union(from persona in personas2
                                             select persona)
                                  orderby alias.Nombre
                                  select alias.Nombre)
    .ToList();


// esto es lo mismo pero un poco mas simplificado
List<string> nombresDePersonas2 = (from alias in 
                                       personas.Union(personas2)
                                   orderby alias.Nombre
                                   select alias.Nombre).ToList();


#endregion

#region uso-del-join

var names = new List<(string name, int fkSurrname)>()
{
    ("Matias", 1),
    ("Alejandro", 1),
    ("Nicolas", 2),
    ("Ariel", 3)
};

var surrnames = new List<(int idSurrname, string surrname)>()
{
    (1, "Rapoport"),
    (2, "Fishman"),
    (3, "Garfinkel")
};

var people = names.Join(surrnames, n => n.fkSurrname, s => s.idSurrname, (nombre, apellido) =>
{
    return new
    {
        Name = nombre.name,
        surrname = apellido.surrname
    };
});


#endregion









var breaking = 0;

public class Complejo
{
    public int numero { get; set; }
    public string cadena { get; set; }

    public Complejo(int numero, string cadena)
    {
        this.numero = numero;
        this.cadena = cadena;
    }

    public string Imprimir()
    {
        return numero + "   " + cadena;
    }
}

public class Persona
{
    public int Edad { get; set; }
    public string Nombre { get; set; }
}
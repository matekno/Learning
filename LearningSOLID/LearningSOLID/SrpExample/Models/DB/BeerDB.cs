using SrpExample.Models.ViewModels;

namespace SrpExample.Models.DB;

public class BeerDB
{
    // Responsabilidad: guardar la cerveza en la BDD
    public void Save(BeerViewModel beer)
    {
        Console.WriteLine("Guardado en BDD" + beer.Name); // simulamos guardado en BDD
    }
}
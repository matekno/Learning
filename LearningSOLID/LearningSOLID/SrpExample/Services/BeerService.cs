using SrpExample.Models.DB;
using SrpExample.Models.ViewModels;
using SrpExample.Utils;
namespace SrpExample.Services;

public class BeerService
{
    // Responsabilidad: Ejecutar la mecanica de las cervezas.
    public void Create(BeerViewModel beer)
    {
        var BeerDB = new BeerDB();
        var Log = new Log();
        
        BeerDB.Save(beer);
        Log.Save(beer.BeerInfo());
    }
}
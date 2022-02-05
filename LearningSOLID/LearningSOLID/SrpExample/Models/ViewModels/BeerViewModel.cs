namespace SrpExample.Models.ViewModels;

public class BeerViewModel
{
    // Responsabilidad: presentar la informacion de la cerveza
    public string Name { get; set; }
    public string Brand { get; set; }

    public string BeerInfo() => $"Nombre: {this.Name}       Marca: {this.Brand}";
    }
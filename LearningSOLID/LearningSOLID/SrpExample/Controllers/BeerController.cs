using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SrpExample.Models;
using SrpExample.Models.ViewModels;
using SrpExample.Services;

namespace SrpExample.Controllers;

public class BeerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Add(BeerViewModel beer)
    {
        var BeerService = new BeerService();
        if (!ModelState.IsValid) // si el viewmodel es valido
        {
            return View(beer); 
        }

        BeerService.Create(beer);
        return Ok();
    }
}
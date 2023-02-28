using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;

namespace Pokedex.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Pokemon bulba = new Pokemon();
        bulba.Numero = 1;
        bulba.Nome = "Bulbasaur";
        bulba.Tipo.Add("Planta");
        bulba.Tipo.Add("Venenoso");
        // bulba.Tipo.AddRange(new string[] {"Planta", "Venenoso"});
        bulba.Imagem = "\\img\\pokemons\\001.png";

        Pokemon ivy = new()
        {
            Numero = 2,
            Nome = "Ivysaur",
            Tipo = {"Planta", "Venenoso"},
            Imagem = "\\img\\pokemons\\002.png"
        };
        
        var venu = new Pokemon();

        ViewData["Ivysaur"] = ivy;

        return View(bulba);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

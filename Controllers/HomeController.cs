using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP10.Models;

namespace TP10.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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
    public IActionResult Index(int IdSerie)
    {
        ViewBag.series_=CargarTodasSeries();
        return View("Index");
    }
     [HttpPost]
     public Series MostrarDetalleSerie(int IdSerie){
        Series serie_=BD.CargarSerie(IdSerie);
        return serie_;
     }
     [HttpPost]
      public List <Series> CargarTodasSeries(){
        List <Series> series_=BD.CargarTodasSeries();
        return series_;
     }
     [HttpPost]
     public List <Actores> MostrarDetalleActor(int IdSerie){
         List <Actores> actores_=BD.CargarActores(IdSerie);
        return actores_;
     }
     [HttpPost]
     public List <Temporadas> MostrarDetalleTemporadas( int IdSerie){
        List <Temporadas> temporadas_=BD.CargarTemporada(IdSerie);
        return temporadas_;
     }
}

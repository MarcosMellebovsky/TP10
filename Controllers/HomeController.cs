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

    public IActionResult Index()
    {
        ViewBag.ListaSeries = BD.ListarSeries();
        return View();
    }

     public Series VerDetalleSeries(int idSerie)
    {  
        Series MiSerie = BD.InfoSeries(idSerie);
        return MiSerie;
    }

    public Temporadas VerDetalleTemporada(int idTemporada)
    {  
        Temporadas MiTemporada = BD.InfoTemporada(idTemporada);
        return MiTemporada;
    }

    public Actores VerDetalleActores(int idActor)
    {  
        Actores MiActor = BD.InfoActores(idActor);
        return MiActor;
    }

   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

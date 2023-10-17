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

    public List<Temporadas> VerDetalleTemporada(int idSerie)
    {  
        List<Temporadas> Temporadas = BD.ListarTemporadas(idSerie);
        return Temporadas;
    }

   public List<Actores> VerDetalleActores(int idSerie)
    {  
        List<Actores> actores = BD.ListarActores(idSerie);
        return actores;
    }

   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

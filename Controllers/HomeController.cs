using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly MvcMovieContext _context; // ????? DbContext

    public HomeController(ILogger<HomeController> logger, MvcMovieContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        // ??? ????? ?? ???????
        var movies = _context.Movie.ToList();

        return View(movies); // ??????? ??? View
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

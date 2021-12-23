using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GymScheduler.Models;

namespace GymScheduler.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> log;
    private readonly GymSchedulerDbContext dbContext;

    public HomeController(ILogger<HomeController> log, GymSchedulerDbContext dbContext)
    {
        this.log = log;
        this.dbContext = dbContext;
    }

    public IActionResult Index()
    {
        return View();
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

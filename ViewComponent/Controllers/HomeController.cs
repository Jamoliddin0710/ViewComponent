using Microsoft.AspNetCore.Mvc;
using ViewComponent.Models;

namespace ViewComponent.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("/about")]
    public IActionResult About()
    {
        return View();
    }

    [Route("/example")]
    public IActionResult ExampleViewComponent()
    {
        var persons = new List<Person>()
        {
            new Person()
            {
                UserName = "@durov",
                Subject = "CTO",
            },
            new Person()
            {
                UserName = "@nimadir",
                Subject = "ishsiz"
            },
        };
        
        return View("Components/Grid/Sample",persons);
    }
}
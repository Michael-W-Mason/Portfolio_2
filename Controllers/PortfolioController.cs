using Microsoft.AspNetCore.Mvc;
namespace Portfolio_2.Controllers;
public class Portfolio : Controller
{
    [HttpGet("")]
    public ViewResult Home()
    {
        return View("Home");
    }

    [HttpGet("projects")]
    public ViewResult Project()
    {
        return View("Project");
    }

    [HttpGet("contact")]
    public ViewResult Contact()
    {
        return View("Contact");
    }

    [HttpPost("formsubmit")]
    public IActionResult FormSubmit(string name, string email, string message){
        return RedirectToAction("Home");
    }
}


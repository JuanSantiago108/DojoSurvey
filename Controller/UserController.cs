using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;


public class UserController : Controller
{
    [HttpGet("")]
    public ViewResult Register()
    {
        return View("Register");
    }

    [HttpPost("user/process-registration")]
    public IActionResult Detail(User newUser)
    {
        return View("Detail", newUser);
    }
}
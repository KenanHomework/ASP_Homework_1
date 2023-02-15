using Microsoft.AspNetCore.Mvc;
using ASP_Homework_1.Models;
using ASP_Homework_1.Services;
using Microsoft.AspNetCore.Identity;

namespace ASP_Homework_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            var messanger = new MessangerService(new DebugMessageFactory(), new DebugClient(new DebugSettings()
            {
                Host = "smtp.example.com",
                Port = 25
            }));

            messanger.SendMessage(user);

            return View();
        }
    }
}

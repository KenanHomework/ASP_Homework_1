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
            var messanger = new MessangerService(new FeedbackMessageFactory(), new FeedbackClient(new FeedbackSettings()
            {
                Type = FeedbackSettings.FeedbackType.Thanks
            }));

            messanger.SendMessage(user);

            return View();
        }
    }
}

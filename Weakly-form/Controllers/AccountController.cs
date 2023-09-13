using Microsoft.AspNetCore.Mvc;

namespace Weakly_form.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginPost(string Username, string Password)
        {
            // check if username and password are matched or not
            bool matched = true;
            if (matched)
            {
                ViewBag.Username = Username;
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Phase4PracticeProj4.Controllers
{
    public class LoginDashboardController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "Ramana" && password == "ramana@345")
            {
                return RedirectToAction("Dashboard");
            }
            ViewBag.ErrorMessage = "Invalid username or password";
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}

using HotelRepos.Models;
using HotelRepos.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelRepos.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMesRepository repo;

        public HomeController(IMesRepository r)
        {
            repo = r;
        }
       

        
        //public async Task<IActionResult> Index()
        //{
        //    var model = await repo.AllMes();
        //    return View(model);
        //}
        public IActionResult Index()
        {
            return View();
        }


        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


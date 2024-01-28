using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelRepos.Models;
using HotelRepos.Repository;
using Microsoft.AspNetCore.Authorization;

namespace HotelRepos.Controllers
{
	//[Authorize]
	public class MesController : Controller
    {
        private readonly IMesRepository repo;
        private readonly IUserRepository repo2;


        public MesController(IMesRepository r, IUserRepository ur)
        {
            repo = r;
            repo2=ur;   
        }

        public async Task<IActionResult> AllMes()
        {
            var mes = await repo.AllMes();
            return View(mes);

        }

        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
		//[Authorize]
		public async Task<IActionResult> Create([Bind("Id,Message,Datetime")] Messages mes)
        {
            var id = HttpContext.Session.GetString("Id");
            var user = await repo2.GetUser(int.Parse(id));
            if (ModelState.IsValid)
               
            {
                mes.user = user;
                mes.Datetime = DateTime.Now;
                await repo.Create(mes);
                await repo.Save();
                return RedirectToAction(nameof(AllMes));
            }
            return View(mes);
        }

        

        //public async Task<IActionResult> Index()
        //{
        //    var model = repo.AllMes();
        //    return View(await model);
        //}
        

    }
}
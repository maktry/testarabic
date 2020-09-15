using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArabicProject.Data;
using ArabicProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArabicProject.Controllers
{
    public class AdController : Controller
    {
        public readonly ApplicationDbContext _Context;

      public  AdController(ApplicationDbContext applicationDb)
        {
            _Context = applicationDb;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateAd()
        {
            var GetAllSections = _Context.TypeOfAd.Where(p => p.ZeroActive == false).ToList();
            ViewBag.AdTypes = GetAllSections;
            return View();
        }

        [HttpPost]
        public IActionResult CreateAd(AdEntree db)
        {
            if(ModelState.IsValid) {
                AdEntree x = new AdEntree();
                x.Title = db.Title;
                x.TypeOfAd = db.TypeOfAd;
                x.DateWritten = DateTime.Now;
                x.Author = "ddd";
                _Context.AdEntree.Add(x);
                _Context.SaveChanges();
                //   x.Author = _Context.Users.id
                return RedirectToAction("index", "home");
            }

            return View();
        }
        

        [HttpGet]

        public IActionResult CreateTypeOfAd()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CreateTypeOfAd(TypeOfAd x)
        {

            if (ModelState.IsValid)
            {
                TypeOfAd newSec = new TypeOfAd();

                newSec.Name = x.Name;
                newSec.ZeroActive = false;

                _Context.TypeOfAd.Add(x);
                _Context.SaveChanges();
            }
            return View();
        }
    }
}
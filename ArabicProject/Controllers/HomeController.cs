using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArabicProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using ArabicProject.ViewModels;
using ArabicProject.Data;

namespace ArabicProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _Context;
        private readonly ITableUpdate<sections> _Section;
        private readonly ITableUpdate<Blog> _Blog;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext applicationDbContext,ITableUpdate<sections> section,ITableUpdate<Blog> blog )
        {
            _logger = logger;
            _Context = applicationDbContext;
           _Section = section;
            _Blog = blog;


        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var alSections = _Section.Find(p => p.Id == 2);//_Section.GetAll();

            return View(alSections);
        }

        public IActionResult myBlogs()
        {
            return View();//_Blog.Find(p => p.Title.Contains('f')).ToList);

        }
        [HttpGet]
        public IActionResult WriteBlog()
        {

            BlogModel x = new BlogModel();
                         x._section = _Context.Sections.Where(p => p.ActiveZero == false).ToList();

            

       

                        return View(x);
        }
        [HttpPost]
        public IActionResult WriteBlog(BlogModel model)
        {


            var name = model.BodyText;
            var selected = model.selected;
            var ss = model._section;
            var mmm = model.selected;

            ViewBag.ListItems = ss;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

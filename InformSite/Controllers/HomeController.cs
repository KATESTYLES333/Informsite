using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InformSite.Models;
using InformSite.ViewModels;
using PagedList.Mvc;
using PagedList;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InformSite.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationContext _context;
           
        
        public IEnumerable<Category> Categories { get; set; }
        List<Project> projects { get; set; }
        List<Category> categories { get; set; }
        public HomeController(ApplicationContext context)
        {
            _context = context;

            categories = _context.Categories.ToList();

             projects = _context.Projects.ToList();
      
             }

        [HttpGet]
               public IActionResult Index(int? categoryId)
               {

                   List<Category> catModels = categories
                          .Select(c => new Category { CategoryId = c.CategoryId, Title = c.Title })
                          .ToList();
                    catModels.Insert(0, new Category { CategoryId = 0, Title = "Все" });
                    IndexViewModel ivm = new IndexViewModel { Categories = catModels, Projects = projects };
                    if (categoryId != null && categoryId > 0)
                        ivm.Projects = projects.Where(p => p.Category.CategoryId == categoryId);
            return View(ivm);
        } 

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

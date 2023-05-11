using InformSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformSite.Controllers
{
    public class ProjectController : Controller
    {
       /* SoccerContext db = new SoccerContext();
        public ActionResult Index()
        {
            var projects = db.Projects.Include(p => p.Category);
            return View(projects.ToList());
        }
        public ActionResult Details(int? CategoryId)
        {
           

            Category category = db.Categories.Find(CategoryId);

            category.Projects = db.Projects.Where(m => m.CategoryId == category.CategoryId);
            return View(category);
        }

        [HttpGet]
        public ActionResult Create()
        {
            // Формируем список команд для передачи в представление
            SelectList categories = new SelectList(db.Categories, "CategoryId", "Title");
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Project project)
        {
            //Добавляем игрока в таблицу
            db.Projects.Add(project);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }*/
    }
}

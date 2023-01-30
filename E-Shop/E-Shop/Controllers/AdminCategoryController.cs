using BussinuessLayer.Concreate;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryRepository categoryRepository = new CategoryRepository();
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            return View(categoryRepository.List());
        }
        public ActionResult Create()
        {
            return View();

        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Category data)
        {
            if (ModelState.IsValid)
            {
                categoryRepository.Insert(data);
                return RedirectToAction("Index");
            }
            return View(data);


        }

        public ActionResult Update(int id)
        {
            var cat = categoryRepository.GetbyId(id);
            return View(cat);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Update(Category data)
        {
            if (ModelState.IsValid)
            {
                var cat = categoryRepository.GetbyId(data.Id);
                cat.Description = data.Description;
                cat.Name = data.Name;
                categoryRepository.Update(cat);
                return RedirectToAction("Index");
            }
            return View(data);

        }

        public ActionResult Delete(int id)
        {
            var category = categoryRepository.GetbyId(id);
            categoryRepository.Delete(category);

            return RedirectToAction("/Index");
        }
    }
}


using CitelProject.MVC.Extensions;
using CitelProject.MVC.ViewModels;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace CitelProject.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        private APIExtension aPIExtensions = new APIExtension();

        // GET: Categories
        public async Task<ActionResult> Index()
        {
            string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.CATEGORIES}";
            var categories = await Url.GetJsonAsync<IEnumerable<CategoryViewModel>>();
            return View(categories);
        }

        // GET: Categories/Details/5
        public async Task<ActionResult> Details(int id)
        {
            string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.CATEGORIES}/{id}";
            var category = await Url.GetJsonAsync<CategoryViewModel>();
            return View(category);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        public async Task<ActionResult> Create(CategoryViewModel collection)
        {
            try
            {
                string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.CATEGORIES}";
                var response =  await Url.PostJsonAsync(collection)
                                .ReceiveJson();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: Categories/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.CATEGORIES}/{id}";
            var category = await Url.GetJsonAsync<CategoryViewModel>();

            return View(category);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, CategoryViewModel CategoryViewModel)
        {
            try
            {
                string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.CATEGORIES}/{id}";

                var response = await Url.PutJsonAsync(CategoryViewModel).ReceiveJson();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(CategoryViewModel);
            }
        }

        // GET: Categories/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.CATEGORIES}/{id}";
            var category = await Url.GetJsonAsync<CategoryViewModel>();
            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, CategoryViewModel collection)
        {
            try
            {
                string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.CATEGORIES}/{id}";
                var category = await Url.DeleteAsync();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

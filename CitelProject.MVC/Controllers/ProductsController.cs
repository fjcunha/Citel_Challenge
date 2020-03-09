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
    public class ProductsController : Controller
    {
        private APIExtension aPIExtensions = new APIExtension();

        // GET: Categories
        public async Task<ActionResult> Index()
        {
            string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.PRODUCTS}";
            var categories = await Url.GetJsonAsync<IEnumerable<ProductViewModel>>();
            return View(categories);
        }

        // GET: Categories/Details/5
        public async Task<ActionResult> Details(int id)
        {
            string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.PRODUCTS}/{id}";
            var category = await Url.GetJsonAsync<ProductViewModel>();
            return View(category);
        }

        // GET: Categories/Create
        public async Task<ActionResult> Create()
        {
            IEnumerable<CategoryViewModel> categories = await $"{aPIExtensions.URL_BASE}{aPIExtensions.CATEGORIES}".GetJsonAsync<IEnumerable<CategoryViewModel>>();
            ViewBag.CategoryID = new SelectList(categories, "CategoryID", "Name");

            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        public async Task<ActionResult> Create(ProductViewModel collection)
        {
            try
            {
                string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.PRODUCTS}";
                var response = await Url.PostJsonAsync(collection)
                                .ReceiveJson();
                
                return RedirectToAction("Index");
            }
            catch
            {
                IEnumerable<CategoryViewModel> categories = await $"{aPIExtensions.URL_BASE}{aPIExtensions.CATEGORIES}".GetJsonAsync<IEnumerable<CategoryViewModel>>();
                ViewBag.CategoryID = new SelectList(categories, "CategoryID", "Name");
                return View(collection);
            }
        }

        // GET: Categories/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.PRODUCTS}/{id}";
            var product = await Url.GetJsonAsync<ProductViewModel>();
            IEnumerable<CategoryViewModel> categories = await $"{aPIExtensions.URL_BASE}{aPIExtensions.CATEGORIES}".GetJsonAsync<IEnumerable<CategoryViewModel>>();
            ViewBag.CategoryID = new SelectList(categories, "CategoryID", "Name");
            return View(product);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, ProductViewModel productViewModel)
        {
            try
            {
                string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.PRODUCTS}/{id}";
                var response = await Url.PutJsonAsync(productViewModel).ReceiveJson();
                return RedirectToAction("Index");
            }
            catch
            {
                IEnumerable<CategoryViewModel> categories = await $"{aPIExtensions.URL_BASE}{aPIExtensions.CATEGORIES}".GetJsonAsync<IEnumerable<CategoryViewModel>>();
                ViewBag.CategoryID = new SelectList(categories.ToList(), "CategoryID", "Name");
                return View(productViewModel);
            }
        }

        // GET: Categories/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.PRODUCTS}/{id}";
            var product = await Url.GetJsonAsync<ProductViewModel>();
            return View(product);
        }

        // POST: Categories/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, ProductViewModel collection)
        {
            try
            {
                string Url = $"{aPIExtensions.URL_BASE}{aPIExtensions.PRODUCTS}/{id}";
                var response = await Url.DeleteAsync();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

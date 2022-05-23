using DataLayer;
using LogicLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewLayer.Controllers
{
    public class WebsiteController : Controller
    {
        private WebsiteContainer wCont = new WebsiteContainer(new WebsiteDAL());
        private PageContainer pCont = new PageContainer(new PageDAL());
        // GET: WebsiteController
        public ActionResult Index()
        {
            return View(wCont.GetAllWebsites());
        }

        public ActionResult Pages(int id)
        {
            ViewData["CurrentWebsiteName"] = wCont.FindWebsiteById(id).Name;
            ViewData["CurrentWebsiteDomain"] = wCont.FindWebsiteById(id).Domain;
            return View(pCont.GetAll(id));
        }

        // GET: WebsiteController/Details/5
        public ActionResult Details(int id)
        {
            return View(wCont.FindWebsiteById(id));
        }

        // GET: WebsiteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebsiteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Website newWebsite = new Website(collection["Name"], collection["Domain"]);
                wCont.CreateWebsite(newWebsite);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewData["Error"] = e;
                return View();
            }
        }

        // GET: WebsiteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(wCont.FindWebsiteById(id));
        }

        // POST: WebsiteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                Website newWebsite = new Website(Convert.ToInt32(collection["Id"]), collection["Name"], collection["Domain"]);
                wCont.UpdateWebsite(newWebsite);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewData["Error"] = e;
                return View();
            }
        }

        // GET: WebsiteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(wCont.FindWebsiteById(id));
        }

        // POST: WebsiteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                wCont.DeleteWebsite(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewData["Error"] = e;
                return View();
            }
        }
    }
}

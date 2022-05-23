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
    public class PageController : Controller
    {
        private PageContainer pCont = new PageContainer(new PageDAL());
        private ComponentContainer cCont = new ComponentContainer(new ComponentDAL());
        // GET: PageController/5
        public ActionResult Index()
        {
            return Redirect("/Website");
        }

        public ActionResult Components(int id)
        {
            ViewData["CurrentPage"] = pCont.FindPageById(id);
            return View(cCont.GetAll(id));
        }

        // GET: PageController/Details/5
        public ActionResult Details(int id)
        {
            return View(pCont.FindPageById(id));
        }

        // GET: PageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                pCont.CreatePage(new Page(Convert.ToInt32(collection["WebsiteId"]), collection["Location"]));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(pCont.FindPageById(id));
        }

        // POST: PageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                pCont.EditPage(new Page(Convert.ToInt32(collection["Id"]),Convert.ToInt32(collection["WebsiteId"]), collection["Location"]));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                pCont.DeletePage(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
